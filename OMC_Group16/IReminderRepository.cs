using System;
using System.Collections.Generic;
using System.Text;

namespace OMC_Group16
{
    public interface IReminderRepository
    {
        List<Reminder> GetAllReminders();
        List<Reminder> GetRemindersByDate(DateTime date);
        List<Reminder> GetRemindersByCategory(string category);
        List<Reminder> GetUpcomingReminders(int days = 7);
        Reminder GetReminderById(int id);
        void AddReminder(Reminder reminder);
        void UpdateReminder(Reminder reminder);
        void DeleteReminder(int id);
        void MarkAsCompleted(int id);
        int GetPendingCount();
    }
}
