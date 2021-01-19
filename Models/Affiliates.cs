using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFFILIATES.GB.Models
{
    [Table("AFFILIATES")]
    public partial class Affiliates
    {
        public Affiliates()
        {
            AffiliateContracts = new HashSet<AffiliateContracts>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("firts_name")]
        [StringLength(60)]
        public string FirtsName { get; set; }
        [Required]
        [Column("last_name")]
        [StringLength(60)]
        public string LastName { get; set; }
        [Required]
        [Column("national_id")]
        [StringLength(160)]
        public string NationalId { get; set; }
        [Column("birthday", TypeName = "date")]
        public DateTime Birthday { get; set; }
        [Column("gender")]
        [StringLength(1)]
        public string Gender { get; set; }

        [InverseProperty("Affiliate")]
        public virtual ICollection<AffiliateContracts> AffiliateContracts { get; set; }
    }
}
