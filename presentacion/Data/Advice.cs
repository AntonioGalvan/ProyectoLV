namespace presentacion.Data
{
    public class Advice : IEntity
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string text { get; set; }

        public User User { get; set; }
    }
}
