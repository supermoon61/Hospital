
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Model
{
    public partial class Patient
    {
        public Patient()
        {
            MedicineIssued = new HashSet<Issued>();
         
        }
        [Key]
        public int PID { get; set; }

        [Index(IsUnique = true)]
        [StringLength(50)]
        public string AADHAR { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int Age { get; set; }

        [StringLength(50)]
        public string FatherOrHusband { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }
   
        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(150)]
        public string Address { get; set; }
        public int? Status { get; set; }

        [StringLength(250)]
        public string Note { get; set; }

        public DateTime? CreatedAt { get; set; }
        public virtual ICollection<Issued> MedicineIssued { get; set; }
    }
}
