namespace presentacion
{
    using presentacion.Data;
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestQuestion> TestQuestions { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DataContext() : base("name=Connection")
        {

        }
    }
}
