using System.Collections.Generic;

namespace presentacion.Data
{
    public class Response : IEntity
    {
        public int Id { get; set; }

        public TestQuestion TestQuestion { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
