using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace presentacion.Data
{
    public class Test :IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public Expert Expert { get; set; }
        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}
