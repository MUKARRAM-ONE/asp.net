# Data Model

## Conceptual Schema

### User
Represents a system user.
- **Id**: `int` (PK)
- **Username**: `string` (Unique, Required)
- **Email**: `string` (Unique, Required, EmailAddress)
- **PasswordHash**: `string` (Required)
- **ThemePreference**: `string` (Default: "Light")
- **CreatedAt**: `DateTime`

### Category
Task classification.
- **Id**: `int` (PK)
- **Name**: `string` (Required)
- **ColorHex**: `string` (For UI pills/badges)
- **IconClass**: `string` (FontAwesome class)

### Task
The core work unit.
- **Id**: `int` (PK)
- **UserId**: `int` (FK -> User)
- **CategoryId**: `int` (FK -> Category)
- **Title**: `string` (Required, MaxLength 100)
- **Description**: `string` (Rich Text allowed)
- **Priority**: `enum` (Low, Medium, High)
- **Status**: `enum` (ToDo, InProgress, Done)
- **DueDate**: `DateTime?`
- **CreatedAt**: `DateTime`
- **UpdatedAt**: `DateTime`
- **IsArchived**: `boolean` (Soft delete)

### TaskComment (Optional/Bonus)
- **Id**: `int` (PK)
- **TaskId**: `int` (FK -> Task)
- **UserId**: `int` (FK -> User)
- **Content**: `string`
- **CreatedAt**: `DateTime`

## Entity Framework Core Configuration

- **Relationships**:
  - One User has Many Tasks.
  - One Category has Many Tasks.
  - One Task has Many Comments.
- **Cascade Delete**:
  - Deleting a User deletes their Tasks.
  - Deleting a Task deletes its Comments.
