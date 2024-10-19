namespace Domain.Results
{
    public class Result
    {
        public bool IsSucceeded { get; init; }
        public string[] Errors { get; protected set; }

        public static Result Fails(string[] errors)
        {
            return new Result { IsSucceeded = false, Errors = errors };
        }

        public static Result Succeeds()
        {
            return new Result { IsSucceeded = true };
        }
    }
}
