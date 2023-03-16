using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Room
    {
        [Key]
        public int RoomNumber { get; set; }
        [Required]
        [Range(1,6)]
        public int  Capacity { get; set; }

        public Client? Client { get; set; }
        

    }
}
