using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(length: 255)]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Mony { get; set; }
        [Required, MaxLength(length: 228)]
        public string Email { get; set; }
        [Required, MaxLength(length: 228)]
        public string Password { get; set; }
    }
}
