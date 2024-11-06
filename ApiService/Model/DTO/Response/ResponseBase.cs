namespace ApiService.Model.DTO.Response
{
    public abstract class ResponseBase<T> where T : class
    {
        public required string message { get; set; }    
        public required string status { get; set; }
        public required T data { get; set; }
    }
}
