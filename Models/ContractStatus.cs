using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFFILIATES.GB.Models
{
    [Table("CONTRACT_STATUS")]
    public partial class ContractStatus
    {
        public ContractStatus()
        {
            AffiliateContracts = new HashSet<AffiliateContracts>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("status")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("enable")]
        public bool Enable { get; set; }

        [InverseProperty("ContractStatu")]
        public virtual ICollection<AffiliateContracts> AffiliateContracts { get; set; }
    }
}
