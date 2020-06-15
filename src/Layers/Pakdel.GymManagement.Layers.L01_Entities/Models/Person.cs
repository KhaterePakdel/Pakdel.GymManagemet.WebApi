using Pakdel.GymManagement.Layers.L01_Entities.Enums;
using Pakdel.GymManagement.Layers.L01_Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    public class Person : BaseEntity
    {
        [MaxLength(50)]
        [Required]
        public string Firstname { get; set; }

        [MaxLength(200)]
        [Required]
        public string Lastname { get; set; }

        [Required]
        public string NationalCode { get; set; }

        public GenderType Gender { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthdate { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]

        public DateTime CreationDate { get; set; }


        public Guid? CreationBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastLoginDate { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        
        public string Configuration { get; set; }

        public Guid FileId { get; set; }
        public long GroupAuthId { get; set; }

        public virtual GroupAuth GroupAuth { get; set; }

        

        public virtual FileStorage Image { get; set; }
    }
}
