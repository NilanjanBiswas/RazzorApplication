using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorApplication.Model
{
    public class Book
    {
        [Key]
        public int id  { get; set; }

        [Required]
        public string Name  { get; set; }

        public string Author  { get; set; }

        public string ISBN { get; set; }

        public string Avaibility  { get; set; }

        public string Price  { get; set; }
    }
}
