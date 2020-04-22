namespace presentacion.Data
{
    public class Update :IEntity
    {
        public int Id { get; set; }
        public double Reciclyng { get; set; }
        public double PollutionReduction { get; set; }
        public double Ecology { get; set; }
        public double ActiveParticipation { get; set; }

        public Profile Profile { get; set; }
    }
}
