namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.ressource")]
    public partial class ressource
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ressource()
        {
            evaluation = new HashSet<evaluation>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string CV { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public int? TypeContrat { get; set; }

        public int? TypeDisponibilite { get; set; }

        [StringLength(255)]
        public string addresse { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string firstName { get; set; }

        [StringLength(255)]
        public string lastName { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        public long? tel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<evaluation> evaluation { get; set; }
    }
}
