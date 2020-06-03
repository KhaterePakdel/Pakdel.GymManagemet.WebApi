using Pakdel.GymManagement.Layers.L01_Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{

    [Table("User_T")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Fname { get; set; }

        [MaxLength(200)]
        [Required]
        public string Lname { get; set; }

        [Required]
        public string NationalCode { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Birthdate { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        public UserStatusEnum Status { get; set; }

        public string Configuration { get; set; }
        

        [Column(TypeName = "datetime2")]
        public DateTime LastLogin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationDate { get; set; }

        


    }
}
