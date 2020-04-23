using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace presentacion.Data
{
    public class Question : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(10)]
        public string Number { get; set; }

        public ICollection<TestQuestion> TestQuestions { get; set; }
    }
}
