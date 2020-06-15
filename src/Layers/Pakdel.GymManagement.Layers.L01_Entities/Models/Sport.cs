using Pakdel.GymManagement.Layers.L01_Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("Sport_T")]
   public class Sport : BaseEntity
    {
        public Sport()
        {
            SportGyms = new HashSet<SportGym>();
            
        }

        [Required]
        public string Title { get; set; }
        public SportGenderType GenderType { get; set; }


        public virtual ICollection<SportGym> SportGyms { get; set; }
        
    }
}
