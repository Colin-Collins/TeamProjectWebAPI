namespace TeamProjectWebAPI.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public int DurationInMinutes { get; set; }
    }
}
