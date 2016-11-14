using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDomains
{
    public class School
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Index { get; set; }

        public string Street { get; set; }

        public string House { get; set; }

        public string House2 { get; set; }

        public string Phone { get; set; }

        public string Boss { get; set; }

        //public int SchoolTypeId { get; set; }
        //public int LocalityId { get; set; }

        //[ForeignKey("LocalityId")]
        [Required]
        public virtual Locality Locality { get; set; }

        //[ForeignKey("SchoolTypeId")]
        [Required]
        public virtual SchoolType SchoolType { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
    }
}
