using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationTask.Models
{
    public class UserData
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
    }
}