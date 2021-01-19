using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFFILIATES.GB.Models
{
    [Table("AFFILIATE_CONTRACTS")]
    public partial class AffiliateContracts
    {
        public AffiliateContracts()
        {
            AffiliateContractServices = new HashSet<AffiliateContractServices>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("affiliate_id")]
        public int AffiliateId { get; set; }
        [Column("contract_statu_id")]
        public int ContractStatuId { get; set; }
        [Column("application_date", TypeName = "date")]
        public DateTime ApplicationDate { get; set; }

        [ForeignKey(nameof(AffiliateId))]
        [InverseProperty(nameof(Affiliates.AffiliateContracts))]
        public virtual Affiliates Affiliate { get; set; }
        [ForeignKey(nameof(ContractStatuId))]
        [InverseProperty(nameof(ContractStatus.AffiliateContracts))]
        public virtual ContractStatus ContractStatu { get; set; }
        [InverseProperty("AffiliateContract")]
        public virtual ICollection<AffiliateContractServices> AffiliateContractServices { get; set; }
    }
}
