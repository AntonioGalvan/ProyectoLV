namespace presentacion.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Expert :IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(20)]
        public string City { get; set; }
        [Required]
        [StringLength(20)]
        public string Degree { get; set; }
        [StringLength(200)]
        public string ImageUrl { get; set; }
        
        public ICollection<User> Users { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}
