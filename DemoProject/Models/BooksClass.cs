using System;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models
{
    public class Books
    {

        [Key]
        public int Key { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }

    }
}
