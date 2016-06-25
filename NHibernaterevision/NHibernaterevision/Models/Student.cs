using System;
using System.Text;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;


namespace Sample.CustomerService.Domain {
    
    public class Student {
        public virtual int StudentId { get; set; }
        public virtual string Studentname { get; set; }
        public virtual string Studentemail { get; set; }
        public virtual string Teacherid { get; set; }
    }
}
