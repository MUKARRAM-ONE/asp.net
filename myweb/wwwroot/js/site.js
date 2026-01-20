// Theme helpers
(function () {
	function applyTheme(theme) {
		document.documentElement.setAttribute('data-theme', theme === 'dark' ? 'dark' : 'light');
		try { localStorage.setItem('theme', theme); } catch (e) {}
	}

	// Apply saved theme on load
	var saved = null;
	try { saved = localStorage.getItem('theme'); } catch (e) {}
	applyTheme(saved || 'light');
})();
