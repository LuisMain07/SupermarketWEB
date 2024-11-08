using System.ComponentModel.DataAnnotations;
using Microsoft.Identity.Client;
using SupermarketWEB.Models;

namespace SupermarketWEB.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
