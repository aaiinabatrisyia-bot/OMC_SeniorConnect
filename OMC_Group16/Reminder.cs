using System;
using System.Collections.Generic;
using System.Text;

namespace OMC_Group16
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReminderDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCompleted { get; set; }
        public int Priority { get; set; } // 1=Low, 2=Medium, 3=High
        public string Category { get; set; }

        public string StatusText => IsCompleted ? "✅ Completed" : "⏳ Pending";

        public Reminder()
        {
            CreatedAt = DateTime.Now;
            IsCompleted = false;
            Priority = 2;
        }

    }
}
