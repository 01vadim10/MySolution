using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Title")]
    public class Department
    {
        public Department()
        {
            Contacts = new List<Contact>();
        }
        [Browsable(false)]
        public Int32 ID { get; protected set; }
        public String Title { get; set; }
        public String Office { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
    }
}
