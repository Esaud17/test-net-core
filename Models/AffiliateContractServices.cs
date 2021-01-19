using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFFILIATES.GB.Models
{
    [Table("AFFILIATE_CONTRACT_SERVICES")]
    public partial class AffiliateContractServices
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("affiliate_contract_id")]
        public int AffiliateContractId { get; set; }
        [Column("service_id")]
        public int ServiceId { get; set; }
        [Column("observation")]
        [StringLength(150)]
        public string Observation { get; set; }

        [ForeignKey(nameof(AffiliateContractId))]
        [InverseProperty(nameof(AffiliateContracts.AffiliateContractServices))]
        public virtual AffiliateContracts AffiliateContract { get; set; }
        [ForeignKey(nameof(ServiceId))]
        [InverseProperty(nameof(Services.AffiliateContractServices))]
        public virtual Services Service { get; set; }
    }
}
