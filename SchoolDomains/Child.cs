using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchoolDomains
{
  
    public enum EnumSex
    {
        M = 1,
        W = 2
    }

    public class Child
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PatranomicName { get; set; }

        public DateTime BDate { get; set; }

        [Required]
        public EnumSex Sex { get; set; }

        public string Index { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string House { get; set; }

        public string House2 { get; set; }

        public string Flat { get; set; }

        public string Phone { get; set; }

        public string Sertifact { get; set; }

        public int? CC1 { get; set; }

        public int? CC2 { get; set; }

        public int? CC3 { get; set; }

        public int? CC4 { get; set; }

        public string SvSer1 { get; set; }

        public string SvSer2 { get; set; }

        public string SvNum { get; set; }

        public string SvOther { get; set; }

        public string FormOfStudy { get; set; }

        public string TypeOfStudy { get; set; }

        [Required]
        public virtual Class Class { get; set; }

        [Required]
        public virtual Nationality Nationality { get; set; }
    }
}
