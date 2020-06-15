using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("UserGym_T")]
    public class UserGym
    {

        public Guid UserId { get; set; }
        public long GymId { get; set; }


        public virtual User User { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
