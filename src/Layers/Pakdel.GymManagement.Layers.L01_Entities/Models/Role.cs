using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("Role_T")]
    public class Role : AuthEntity
    {
        public Role()
        {
            UserRoles = new HashSet<UserRole>();
        }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }


        public virtual ICollection<UserRole> UserRoles { get; set; }
        public virtual ICollection<GroupAuthRole> GroupRoles { get; set; }
    }
}
