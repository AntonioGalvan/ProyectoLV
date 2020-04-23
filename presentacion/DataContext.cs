namespace presentacion
{
    using presentacion.Data;
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DbSet<Question> Advices { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<User> Profiles { get; set; }
        public DbSet<Test> Updates { get; set; }
        public DataContext() : base("name=Connection")
        {

        }
    }
}
