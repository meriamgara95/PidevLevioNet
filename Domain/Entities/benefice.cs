namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.benefice")]
    public partial class benefice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idBenefice { get; set; }

        public float budget { get; set; }

        public float budgetCourant { get; set; }

        public int mois1 { get; set; }

        public int mois10 { get; set; }

        public int mois11 { get; set; }

        public int mois12 { get; set; }

        public int mois2 { get; set; }

        public int mois3 { get; set; }

        public int mois4 { get; set; }

        public int mois6 { get; set; }

        public int mois7 { get; set; }

        public int mois8 { get; set; }

        public int mois9 { get; set; }

        public float prix { get; set; }

        public int? projet_id { get; set; }

        public virtual projet projet { get; set; }
    }
}
