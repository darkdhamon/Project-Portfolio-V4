using System.Collections;

namespace BHB.Common.API
{
    public enum Status
    {
        Success,
        Failure
    }
    public class ApiResponse
    {
        private string _message;
        public Status Status { get; set; } = Status.Success;

        public string Message
        {
            get => _message??Status.ToString();
            set => _message = value;
        }
    }

    public class ApiResponse<T> :ApiResponse
    {
        public T Data { get; set; }
    }

    public class PagedApiResponse<TList> : ApiResponse<TList> where TList : IEnumerable
    {
        public int Page { get; set; }
        public int NumPerPage { get; set; }
        public int TotalPages { get; set; }
    }
}
