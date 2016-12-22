using System;
using System.Collections.Generic;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Contact : Person
    {
        public Contact()
        {
            TrackedTasks = new List<DemoTask>();
            Subordinates = new List<Contact>();
        }

        public string WebPageAddress { get; set; }
        public string NickName { get; set; }
        public string SpouseName { get; set; }
        public TitleOfCourtesy TitleOfCourtesy { get; set; }
        public DateTime? Anniversary { get; set; }
        [FieldSize(4096)]
        public String Notes { get; set; }
        public virtual Position Position { get; set; }
        public virtual IList<DemoTask> TrackedTasks { get; set; }
        public virtual Department Department { get; set; }
        [DataSourceProperty("Department.Contacts", DataSourcePropertyIsNullMode.SelectAll)]
        [DataSourceCriteria("Position.Title = 'Manager'")]
        public virtual Contact Manager { get; set; }
        public virtual IList<Contact> Subordinates { get; set; }
    }
    public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };
}
