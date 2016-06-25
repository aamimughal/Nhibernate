using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Teacher {
        public virtual int Teacherid { get; set; }
        public virtual string Teachername { get; set; }
        public virtual string Teacheremail { get; set; }
    }
}
