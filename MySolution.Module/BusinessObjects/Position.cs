using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace MySolution.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Title")]
    public class Position
    {
        public Position()
        {
            Contacts = new List<Contact>();
        }
        [Browsable(false)]
        public Int32 ID { get; protected set; }
        [RuleRequiredField(DefaultContexts.Save)]
        public String Title { get; set; }
        public virtual IList<Contact> Contacts { get; set; }
    }
}
