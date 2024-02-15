using System.Net;

namespace Application.shared.Models
{
    public class ShopHubResponseModel
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public bool IsValid { get; set; }
        public dynamic Data { get; set; }
        
        public ShopHubResponseModel() {
            StatusCode =(int)HttpStatusCode.OK;
            Message = string.Empty;
            IsValid = true;
            Data = null;
        }

        public void SetSuccess()
        {
            StatusCode = (int)HttpStatusCode.OK;
            IsValid = true;
            Message = "Request processed successfully";
        }

        public void SetSuccess(dynamic data)
        {
            StatusCode = (int)HttpStatusCode.OK;
            IsValid = true;
            Message = "Request processed successfully";
            Data = data;
        }
        public void SetSuccess(HttpStatusCode code,string message= "")
        {
            StatusCode = (int)code;
            IsValid = true;
            Message = message;
        }

        public void SetError()
        {
            StatusCode = (int)(HttpStatusCode.InternalServerError);
            IsValid = false;
            Message = "Something went wrong";
        }
        public void SetError(HttpStatusCode code, string message="")
        {
            StatusCode = (int)(HttpStatusCode.InternalServerError);
            IsValid = false;
            Message = message;
        }
    }

    public class ShopHubResponseModel<TResponse> : ShopHubResponseModel 
    {
        public new TResponse Data { get; set; }
        public void SetSuccess(HttpStatusCode statusCode, TResponse data) {
            base.SetSuccess(statusCode);
            Data = data;
        }
    }
}
