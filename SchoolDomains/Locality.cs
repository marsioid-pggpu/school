using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDomains
{
    public class Locality
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ShName { get; set; }

        public virtual ICollection<School> Schools { get; set; }
    }
}
