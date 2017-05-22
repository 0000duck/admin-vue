namespace Test_element.UI.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        [Required]
        [StringLength(50)]
        public string NickName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(200)]
        public string Avatar { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
