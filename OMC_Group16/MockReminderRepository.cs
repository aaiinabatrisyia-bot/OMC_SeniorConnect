using System;
using System.Collections.Generic;
using System.Text;

namespace OMC_Group16
{
    public class MockReminderRepository : IReminderRepository
    {
        private List<Reminder> _reminders = new List<Reminder>();
        private int _nextId = 1;

        public MockReminderRepository()
        {
            LoadMockData();
        }

        private void LoadMockData()
        {
            _reminders = new List<Reminder>
            {
                new Reminder
                {
                    Id = _nextId++,
                    Title = "Appointment with Dr. Ahmad",
                    Description = "Regular checkup at Klinik Kesihatan",
                    ReminderDate = DateTime.Now.AddDays(2).AddHours(10),
                    Priority = 3,
                    Category = "Health"
                },
                new Reminder
                {
                    Id = _nextId++,
                    Title = "Take Medication",
                    Description = "Take blood pressure medication",
                    ReminderDate = DateTime.Now.AddHours(8),
                    Priority = 3,
                    Category = "Health"
                },
                new Reminder
                {
                    Id = _nextId++,
                    Title = "Family Gathering",
                    Description = "Dinner at Kak Long's house",
                    ReminderDate = DateTime.Now.AddDays(5).AddHours(18),
                    Priority = 2,
                    Category = "Family"
                },
                new Reminder
                {
                    Id = _nextId++,
                    Title = "Pay Utility Bills",
                    Description = "Electricity and water bills due",
                    ReminderDate = DateTime.Now.AddDays(3).AddHours(12),
                    Priority = 2,
                    Category = "Finance"
                },
                new Reminder
                {
                    Id = _nextId++,
                    Title = "Yoga Class",
                    Description = "Weekly yoga session",
                    ReminderDate = DateTime.Now.AddDays(-1).AddHours(17),
                    Priority = 1,
                    Category = "Wellness",
                    IsCompleted = true
                }
            };
        }

        public List<Reminder> GetAllReminders()
        {
            return _reminders.OrderBy(r => r.ReminderDate).ToList();
        }
        public List<Reminder> GetRemindersByDate(DateTime date)
        {
            return _reminders.Where(r => r.ReminderDate.Date == date.Date)
                            .OrderBy(r => r.ReminderDate)
                            .ToList();
        }
        public List<Reminder> GetRemindersByCategory(string category)
        {
            return _reminders.Where(r => r.Category.ToLower() == category.ToLower())
                            .OrderBy(r => r.ReminderDate)
                            .ToList();
        }
        public List<Reminder> GetUpcomingReminders(int days = 7)
        {
            return _reminders.Where(r => r.ReminderDate >= DateTime.Now
                                        && r.ReminderDate <= DateTime.Now.AddDays(days)
                                        && !r.IsCompleted)
                            .OrderBy(r => r.ReminderDate)
                            .ToList();
        }
        public Reminder GetReminderById(int id)
        {
            return _reminders.FirstOrDefault(r => r.Id == id);
        }
        public void AddReminder(Reminder reminder)
        {
            reminder.Id = _nextId++;
            reminder.CreatedAt = DateTime.Now;
            _reminders.Add(reminder);
        }
        public void UpdateReminder(Reminder reminder)
        {
            var existing = GetReminderById(reminder.Id);
            if (existing != null)
            {
                existing.Title = reminder.Title;
                existing.Description = reminder.Description;
                existing.ReminderDate = reminder.ReminderDate;
                existing.Priority = reminder.Priority;
                existing.Category = reminder.Category;
                existing.IsCompleted = reminder.IsCompleted;
            }
        }
        public void DeleteReminder(int id)
        {
            var reminder = GetReminderById(id);
            if (reminder != null)
                _reminders.Remove(reminder);
        }
        public void MarkAsCompleted(int id)
        {
            var reminder = GetReminderById(id);
            if (reminder != null)
                reminder.IsCompleted = true;
        }
        public int GetPendingCount()
        {
            return _reminders.Count(r => !r.IsCompleted && r.ReminderDate >= DateTime.Now);
        }
    }
}
