﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace presentacion.Data
{
    public class Client : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }

        public Response Response {get; set;}
        public ICollection<User> Users { get; set; }
    }
}
