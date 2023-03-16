using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Must be there character at least!")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Must be there character at least!")]
        public string LastName { get; set; }
        public string PhoneNum { get; set; }

    }
}
