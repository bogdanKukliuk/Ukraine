using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context.Tables
{
    public class librarian
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(length: 228)]
        public string Name { get; set; }
        /*[Required, ForeignKey("User")]
        public int IdUser { get; set; }*/
        [Required, MaxLength(length: 228)]
        public string Post { get; set; }
        [Required, MaxLength(length: 228)]
        public string Debtors { get; set; }
        public virtual ICollection<InfoBook> InfoBooks { get; set; }
        [Required]
        public User Users { get; set; }
    }
}
