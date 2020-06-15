using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("UserToken_T")]

    public class UserToken : AuthEntity
    {
        public string AccessTokenHash { get; set; }

        public DateTimeOffset AccessTokenExpiresDateTime { get; set; }

        [Required]
        [MaxLength(500)]
        public string RefreshTokenIdHash { get; set; }

        [MaxLength(500)]
        public string RefreshTokenIdHashSource { get; set; }

        public DateTimeOffset RefreshTokenExpiresDateTime { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
    }
}
