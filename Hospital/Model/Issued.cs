using System;
using System.ComponentModel.DataAnnotations;

namespace Hospital.Model
{
    public partial class  Issued
    {
        [Key]
        public int issueID { get; set; }
        public DateTime? Date { get; set; }
        public int OPD { get; set; }

        public int? PID { get; set; }

        [StringLength(50)]
        public string Medicines { get; set; }

        public int Days { get; set; }

        public DateTime? NextIssueDate { get; set; }

        [StringLength(50)]
        public string DoctorName { get; set; }

        [StringLength(50)]
        public string Disease { get; set; }

        public DateTime? CreatedAt { get; set; }

        public int? CreatedBy { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
