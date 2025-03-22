namespace BlazorApp3.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string> { "", "", "", "" }; // 4 варианта ответа
        public int CorrectAnswerIndex { get; set; } // Индекс правильного ответа (0-3)

        public int TestModelId { get; set; }
        
        public TestModel Test{ get; set; }//навигационное свойство
    }
}