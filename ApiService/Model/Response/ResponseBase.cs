namespace ApiService.Model.Response
{
    public abstract class ResponseBase
    {
        public required string status { get; set; }
        public abstract required object data { get; set; }
    }
}
