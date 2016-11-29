using System;

namespace Logic.Service
{
    public enum ResultStatus
    {
        Ok,
        AccessFail,
        Timeout,
        NotFound,
        Unknown,
        InvalidParameter,
        Repeat
         
    }
    public class ServiceResult
    {
        public ResultStatus Status { get; set; } = ResultStatus.Unknown;
        public string Message { get; set; }
        public ServiceResult()
        {
        }

        public ServiceResult(ResultStatus status = ResultStatus.Ok)
        {
            Status = status;

        }
    }

    public class ServiceResult<T> : ServiceResult where T : class
    {
        private T _result;
        public T Result {
            get { return _result; }
            set
            {
                if (value == null)
                {
                    Status = ResultStatus.NotFound;
                }
                else
                {
                    Status = ResultStatus.Ok;
                    _result = value;
                }
            }
        }

        public ServiceResult()
        { }
        public ServiceResult(T result, ResultStatus status = ResultStatus.Ok)
            : base(status)
        {
            Result = result;
        }
    }
}
