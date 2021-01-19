using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AFFILIATES.GB.Models
{
    [Table("SERVICES")]
    public partial class Services
    {
        public Services()
        {
            AffiliateContractServices = new HashSet<AffiliateContractServices>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("code")]
        [StringLength(60)]
        public string Code { get; set; }
        [Required]
        [Column("service_name")]
        [StringLength(40)]
        public string ServiceName { get; set; }
        [Required]
        [Column("description")]
        [StringLength(255)]
        public string Description { get; set; }

        [InverseProperty("Service")]
        public virtual ICollection<AffiliateContractServices> AffiliateContractServices { get; set; }
    }
}
