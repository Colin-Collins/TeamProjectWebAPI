namespace TeamProjectWebAPI.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public string CuisineType { get; set; } = string.Empty;
        public bool IsSpicy { get; set; }
        public int Calories { get; set; }
    }
}
