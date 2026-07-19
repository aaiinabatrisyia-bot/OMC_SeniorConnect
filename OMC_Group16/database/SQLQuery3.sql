CREATE TABLE dbo.Reminders
(
    ReminderID INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    ReminderDate DATE NOT NULL,
    Description NVARCHAR(255),
    Status NVARCHAR(20) DEFAULT 'Pending'
);