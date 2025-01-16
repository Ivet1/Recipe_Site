namespace Recipe_Site.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Ingredients { get; set; }
        public string Instructions { get; set; }
        public string CreatedBy { get; set; } // CreatedBy for storing the username of the creator
        public DateTime CreatedAt { get; set; } // CreatedAt to store the creation date
        public string ImagePath { get; set; } = string.Empty;
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public ApplicationUser User { get; set; }
    }
}
