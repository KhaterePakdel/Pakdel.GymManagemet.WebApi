using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("SportGym_T")]
    public class SportGym 
    {
        public Guid GymId { get; set; }
        public Guid SportId { get; set; }

        public virtual  Gym Gym { get; set; }
        public  virtual Sport Sport { get; set; }

       
    }
}
