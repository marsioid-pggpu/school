using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDomains
{

    public class Class
    {
        public int ClassId { get; set; }

        public int Parallel { get; set; }

        public string Litera { get; set; }

        public string Note { get; set; }

        [Required]
        public virtual ClassType ClassType { get; set; }

        [Required]
        public virtual School School { get; set; }

        public virtual ICollection<Child> Childs { get; set; }
    }
}
