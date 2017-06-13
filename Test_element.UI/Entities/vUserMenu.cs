namespace Test_element.UI.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vUserMenu")]
    public partial class vUserMenu
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MenuCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Name { get; set; }

        public Guid? ParentId { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Href { get; set; }

        [StringLength(200)]
        public string IconInfo { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid UserId { get; set; }
    }
}
