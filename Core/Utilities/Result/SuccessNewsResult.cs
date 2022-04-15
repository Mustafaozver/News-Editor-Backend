namespace Core.Utilities.Result
{
    public class SuccessNewsResult : Result
    {
        public int addedNewsId { get; set; }
        public SuccessNewsResult(string message) : base(true, message)
        {

        }
        public SuccessNewsResult() : base(true)
        {

        }
    }
    public class SuccessLoginResult<AccesToken> : Result
    {
        public int UserId { get; set; }
        public SuccessLoginResult(string message) : base(true, message)
        {

        }
        public SuccessLoginResult() : base(true)
        {

        }
    }
}
