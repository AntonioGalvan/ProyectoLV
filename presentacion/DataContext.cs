namespace presentacion
{
    using presentacion.Data;
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DbSet<Advice> Advices { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DataContext() : base("name=Connection")
        {

        }
    }
}
