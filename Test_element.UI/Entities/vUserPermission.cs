namespace Test_element.UI.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vUserPermission")]
    public partial class vUserPermission
    {
        [Key]
        [Column(Order = 0)]
        public Guid Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PermissionCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid MenuId { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(200)]
        public string Href { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid UserId { get; set; }
    }
}
