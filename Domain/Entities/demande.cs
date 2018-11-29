namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.demande")]
    public partial class demande
    {
        public int id { get; set; }

        public int? age { get; set; }

        [StringLength(255)]
        public string comptences { get; set; }

        [StringLength(255)]
        public string cv { get; set; }

        [StringLength(255)]
        public string diplome { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string image { get; set; }

        [StringLength(255)]
        public string nationalite { get; set; }

        [StringLength(255)]
        public string nomD { get; set; }

        [StringLength(255)]
        public string poste { get; set; }

        [StringLength(255)]
        public string prenomD { get; set; }

        [StringLength(255)]
        public string tel { get; set; }

        [Column(TypeName = "bit")]
        public bool vue { get; set; }

        public int? demandeur_id { get; set; }

        public virtual user user { get; set; }
    }
}
