using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace presentacion.Data
{
    public class User : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(30)]
        public string UserName { get; set; }

        public Client Client { get; set; }
        public Expert Expert { get; set; }
        public ICollection<Advice> Advices { get; set; }
    }
}
