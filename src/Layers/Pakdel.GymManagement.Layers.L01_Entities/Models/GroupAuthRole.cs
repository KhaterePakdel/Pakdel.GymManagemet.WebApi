using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("GroupAuthRole_T")]

    public class GroupAuthRole : BaseEntity
    {
        public long? GroupAuthId { get; set; }

        [Required]
        public long RoleId { get; set; }



        public virtual GroupAuth GroupAuth { get; set; }
        public virtual Role Role { get; set; }
    }
}
