using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("Gym_T")]
    public class Gym : BaseEntity
    {
        public Gym()
        {
            UserGyms = new HashSet<UserGym>();
            SportGyms = new HashSet<SportGym>();

        }
        
        [Required]
        [MaxLength(250)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Address { get; set; }

        [MaxLength(100)]
        public string Phone { get; set; }


        public virtual ICollection<UserGym> UserGyms { get; set; }
        public virtual  ICollection<SportGym> SportGyms { get; set; }

    }
}
