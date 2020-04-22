namespace presentacion.Data
{
    using System.Collections.Generic;
    public class Profile :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string City { get; set; }

        public Contact Contact { get; set; }
        public Expert Expert { get; set; }
        public ICollection<Advice> Advices { get; set; }
        public ICollection<Update> Updates { get; set; }
    }
}
