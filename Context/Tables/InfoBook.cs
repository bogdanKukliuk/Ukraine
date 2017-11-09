using Context.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Tables
{
    public class InfoBook
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(length: 255)]
        public string NameBook { get; set; }
        [Required, MaxLength(length: 255)]
        public string NameAuthor { get; set; }
        [Required]
        public int Price { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
