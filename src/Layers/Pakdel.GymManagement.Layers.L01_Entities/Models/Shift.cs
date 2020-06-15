using Pakdel.GymManagement.Layers.L01_Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("Shift_T")]
    public class Shift : BaseEntity
    {
        public string Title { get; set; }
        public TimeType  TimeType { get; set; }

        public Nullable<TimeSpan> StartTime { get; set; }
        public Nullable<TimeSpan> EndTime { get; set; }
        public ShiftStatus ShiftStatus { get; set; }

        [ForeignKey("SportId")]
        public virtual  Sport  Sport { get; set; }
    }
}
