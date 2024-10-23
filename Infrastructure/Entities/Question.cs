
namespace Infrastructure.SqlServer.Entities
{
    public class Question
    {

        public int Id { get; set; }
        public int QuizId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionType { get; set; } 
        public string DifficultyLevel { get; set; } 
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }

        
        public ICollection<Answer> Answers { get; set; }
        public Quiz Quiz { get; set; }
    }
}
