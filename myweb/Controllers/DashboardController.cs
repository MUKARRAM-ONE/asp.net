using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using myweb.Data;
using myweb.Models;
using TaskStatus = myweb.Models.TaskStatus;
using TaskPriority = myweb.Models.TaskPriority;

namespace myweb.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DashboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async System.Threading.Tasks.Task<IActionResult> Index()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier) ?? "0");
            
            // Get statistics for the dashboard
            var totalTasks = await _context.Tasks.CountAsync(t => t.UserId == userId);
            var completedTasks = await _context.Tasks.CountAsync(t => t.UserId == userId && t.Status == TaskStatus.Done);
            var inProgressTasks = await _context.Tasks.CountAsync(t => t.UserId == userId && t.Status == TaskStatus.InProgress);
            var pendingTasks = await _context.Tasks.CountAsync(t => t.UserId == userId && t.Status == TaskStatus.ToDo);

            // Get recent tasks
            var recentTasks = await _context.Tasks
                .Include(t => t.Category)
                .Where(t => t.UserId == userId)
                .OrderByDescending(t => t.CreatedAt)
                .Take(5)
                .ToListAsync();

            // Get tasks by priority
            var highPriorityTasks = await _context.Tasks.CountAsync(t => t.UserId == userId && t.Priority == TaskPriority.High && t.Status != TaskStatus.Done);
            var mediumPriorityTasks = await _context.Tasks.CountAsync(t => t.UserId == userId && t.Priority == TaskPriority.Medium && t.Status != TaskStatus.Done);
            var lowPriorityTasks = await _context.Tasks.CountAsync(t => t.UserId == userId && t.Priority == TaskPriority.Low && t.Status != TaskStatus.Done);

            // Get tasks by category
            var tasksByCategory = await _context.Categories
                .Select(c => new { 
                    c.Name, 
                    c.ColorHex, 
                    c.IconClass, 
                    TaskCount = c.Tasks.Count(t => t.UserId == userId) 
                })
                .Where(c => c.TaskCount > 0)
                .ToListAsync();

            ViewBag.TotalTasks = totalTasks;
            ViewBag.CompletedTasks = completedTasks;
            ViewBag.InProgressTasks = inProgressTasks;
            ViewBag.PendingTasks = pendingTasks;
            ViewBag.HighPriorityTasks = highPriorityTasks;
            ViewBag.MediumPriorityTasks = mediumPriorityTasks;
            ViewBag.LowPriorityTasks = lowPriorityTasks;
            ViewBag.TasksByCategory = tasksByCategory;
            return View(recentTasks);
        }
    }
}
