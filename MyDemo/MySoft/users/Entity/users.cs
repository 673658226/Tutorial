namespace users.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [Key]
        [StringLength(50)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Psw { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public virtual user_info user_info { get; set; }
    }
}
