using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [ModelDefault("Caption", "Task")]
    public class DemoTask : Task
    {
        public DemoTask() : base()
        {
            TrackedBy = new List<Contact>();
            Priority = Priority.Normal;
        }
        public virtual IList<Contact> TrackedBy { get; set; }
        public Priority Priority { get; set; }
    }

    public enum Priority
    {
        Low = 0,
        Normal = 1,
        High = 2
    }
}
