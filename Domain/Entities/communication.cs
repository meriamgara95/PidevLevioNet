namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.communication")]
    public partial class communication
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public communication()
        {
            solution = new HashSet<solution>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string datetime { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string sujet { get; set; }

        public int? typeCom { get; set; }

        public int verif { get; set; }

        public int? idclient_id { get; set; }

        public virtual client client { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<solution> solution { get; set; }
    }
}
