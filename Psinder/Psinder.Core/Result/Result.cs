using System.Net;


namespace Psinder.Core.Result
{
    public class Result
    {
        public bool IsSucceed { get; set; }
        public List<ErrorMessage> Messages { get; set; } = new ();    
        public HttpStatusCode StatusCode { get; set; }
    }
    public class Result<T> : Result
    {
        public T Value { get; set; }
    }
}