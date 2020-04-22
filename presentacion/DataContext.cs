namespace presentacion
{
    using presentacion.Data;
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        DbSet<Advice> Advices { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<Expert> Experts { get; set; }
        DbSet<Profile> Profiles { get; set; }
        DbSet<Update> Updates { get; set; }
        public DataContext() : base("name=Connection")
        {

        }
    }
}
