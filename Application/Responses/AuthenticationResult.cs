namespace Application.Responses
{
    public class AuthenticationResult : BaseResponse
    {
        public AuthenticationResult()
        {
            
        }
        public AuthenticationResult(string token) : base()
        {
            Token = token;
        }
        public AuthenticationResult(string message, bool success) : base(message, success) 
        {
            
        }
        public AuthenticationResult(List<string> errors) : base(errors) 
        {
            
        }
        public string Token { get; set; }
    }
}