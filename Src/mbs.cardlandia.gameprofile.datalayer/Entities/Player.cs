namespace mbs.cardlandia.userprofile.datalayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            Players2Cards = new HashSet<Players2Cards>();
        }

        [Key]
        public Guid GUID { get; set; }

        public DateTime Modified { get; set; }

        public DateTime Created { get; set; }

        public bool Active { get; set; }

        [Required]
        [StringLength(255)]
        public string DisplayName { get; set; }

        [Required]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        public Guid Password { get; set; }

        public bool IsActivated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Players2Cards> Players2Cards { get; set; }
    }
}
