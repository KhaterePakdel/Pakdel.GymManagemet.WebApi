using Pakdel.GymManagement.Layers.L01_Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{

    [Table("User_T")]
    public class User : Person
    {
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            UserGyms = new HashSet<UserGym>();
            UserTokens = new HashSet<UserToken>();
        }
        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        public UserStatus UserStatus { get; set; }

        [Required]
        public UserType UserType { get; set; }


        public  virtual ICollection<UserRole>  UserRoles { get; set; }
        public virtual ICollection<UserGym>  UserGyms { get; set; }
        public virtual ICollection<UserToken> UserTokens { get; set; }

    }
}
