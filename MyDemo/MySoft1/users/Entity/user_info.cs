namespace users.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_info
    {
        [Key]
        [StringLength(50)]
        public string UserID { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        public virtual users users { get; set; }
    }
}
