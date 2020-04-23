using System.ComponentModel.DataAnnotations;

namespace presentacion.Data
{
    public class User
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
    }
}
