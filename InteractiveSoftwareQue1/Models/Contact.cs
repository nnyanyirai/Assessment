using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SingleDotNetCore.Models
{
    public class Contact
    {
        [Key]
        public long Id { get; set; }
        [Column(TypeName = "bigint")]
        [StringLength(10, MinimumLength = 1)]
        [Required]
        public long CompanyId { get; set; }
        [Column(TypeName = "int")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public int ContactType { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string ContactValue { get; set; }
    }
}
