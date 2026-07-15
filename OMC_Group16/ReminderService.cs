using System;
using System.Collections.Generic;
using System.Text;

namespace OMC_Group16
{
    public class ReminderService
    {
        private readonly IReminderRepository _repository;

        public ReminderService(IReminderRepository repository)
        {
          _repository = repository;
        }
        public List<Reminder> GetAllReminders()
        {
            return _repository.GetAllReminders();
        }
        public List<Reminder> GetUpcomingReminders()
        {
            return _repository.GetUpcomingReminders(7);
        }
        public List<Reminder> GetTodayReminders()
        {
            return _repository.GetRemindersByDate(DateTime.Now);
        }
        public List<Reminder> GetEmergencyReminders()
        {
            var all = _repository.GetAllReminders();
            return all.Where(r => r.Priority == 3 && !r.IsCompleted && r.ReminderDate <= DateTime.Now.AddDays(1))
                      .OrderBy(r => r.ReminderDate)
                      .ToList();
        }
        public List<Reminder> SearchReminders(string keyword)
        {
            var all = _repository.GetAllReminders();
            return all.Where(r => r.Title.ToLower().Contains(keyword.ToLower()) ||
                                 r.Description.ToLower().Contains(keyword.ToLower()) ||
                                 r.Category.ToLower().Contains(keyword.ToLower()))
                      .ToList();
        }
        public void AddReminder(Reminder reminder)
        {
            if (string.IsNullOrWhiteSpace(reminder.Title))
                throw new Exception("Title cannot be empty!");

            if (reminder.ReminderDate < DateTime.Now.Date)
                throw new Exception("Reminder date cannot be in the past!");

            _repository.AddReminder(reminder);
        }
        public void UpdateReminder(Reminder reminder)
        {
            if (string.IsNullOrWhiteSpace(reminder.Title))
                throw new Exception("Title cannot be empty!");

            _repository.UpdateReminder(reminder);
        }
        public void DeleteReminder(int id)
        {
            _repository.DeleteReminder(id);
        }

        public void MarkAsCompleted(int id)
        {
            _repository.MarkAsCompleted(id);
        }
        public int GetPendingCount()
        {
            return _repository.GetPendingCount();
        }
    }
}
