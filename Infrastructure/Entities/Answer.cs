namespace Infrastructure.SqlServer.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }


        public Question Question { get; set; }
        public User User { get; set; }
    }
}
