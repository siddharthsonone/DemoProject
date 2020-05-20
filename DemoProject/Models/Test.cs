using System;
using System.ComponentModel.DataAnnotations;

namespace DemoProject.Models
{
    public class Test
    {


        [Key]
        public int Id { get; set; }
        [Required]
        public string Feature { get; set; }
        public string TestCase { get; set; }
        public string Expected { get; set; }
        public string Observed { get; set; }
        public string Result { get; set; }
        public DateTime LastExecuted { get; set; }
        public string Notes { get; set; }
    }
}

