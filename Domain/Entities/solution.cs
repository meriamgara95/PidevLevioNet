namespace Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pidev.solution")]
    public partial class solution
    {
        public int id { get; set; }

        [StringLength(255)]
        public string datetime { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int? comunication_id { get; set; }

        public int? solutionclient_id { get; set; }

        public virtual client client { get; set; }

        public virtual communication communication { get; set; }
    }
}
