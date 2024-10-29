// === MODEL SETUP (C# Models) ===

namespace LearningPlatform.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public string Duration { get; set; }
        public string Instructor { get; set; }
        public string Image { get; set; }
    }
}