using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Pakdel.GymManagement.Layers.L01_Entities.Models
{
    [Table("FileStorage_T")]
    public class FileStorage
    {
        public Guid FileId { get; set; }

        [MaxLength(20)]
        public string FileType { get; set; }

        public long? FileSize { get; set; }

        public string FilePath { get; set; }

        public DateTime CreationDate { get; set; }


    }
}
