namespace BlazorApp3.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<QuestionModel> Questions { get; set; } = new List<QuestionModel>();
    }
}