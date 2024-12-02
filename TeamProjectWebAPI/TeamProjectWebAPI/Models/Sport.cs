namespace TeamProjectWebAPI.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string SportName { get; set; } = string.Empty;
        public string TeamOrIndividual { get; set; } = string.Empty;
        public int PlayersCount { get; set; }
        public string Season { get; set; } = string.Empty;
    }
}
