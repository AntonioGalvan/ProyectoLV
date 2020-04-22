namespace presentacion.Data
{
    using System.Collections.Generic;
    public class Contact :IEntity
    {
        //sfdsf
        public int Id { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }

        public ICollection<Profile> Profiles { get; set; }
    }
}
