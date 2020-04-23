namespace presentacion.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Profile :IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }
        [Required]
        [StringLength(25)]
        public string City { get; set; }

        public Contact Contact { get; set; }
        public Expert Expert { get; set; }
        public ICollection<Advice> Advices { get; set; }
        public ICollection<Update> Updates { get; set; }
    }
}
