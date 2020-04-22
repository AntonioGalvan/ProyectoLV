namespace presentacion.Data
{
    public class Advice : IEntity
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Author { get; set; }

        public Profile Profile { get; set; }
    }
}
