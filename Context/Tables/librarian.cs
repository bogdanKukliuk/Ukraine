using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required, MaxLength(length: 228)]
        public string Post { get; set; }
        [Required, MaxLength(length: 228)]
        public string Debtors { get; set; }

    }
}
