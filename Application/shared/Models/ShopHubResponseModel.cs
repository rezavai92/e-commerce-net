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

        public ShopHubResponseModel SetSuccess()
        {
            StatusCode = (int)HttpStatusCode.OK;
            IsValid = true;
            Message = "Request processed successfully";

            return this;
        }

        public ShopHubResponseModel SetSuccess(dynamic data)
        {
            StatusCode = (int)HttpStatusCode.OK;
            IsValid = true;
            Message = "Request processed successfully";
            Data = data;

            return this;
        }
        public ShopHubResponseModel SetSuccess(HttpStatusCode code,string message= "")
        {
            StatusCode = (int)code;
            IsValid = true;
            Message = message;

            return this;
        }

        public ShopHubResponseModel SetError()
        {
            StatusCode = (int)(HttpStatusCode.InternalServerError);
            IsValid = false;
            Message = "Something went wrong";

            return this;
        }
        public ShopHubResponseModel SetError(HttpStatusCode code, string message="")
        {
            StatusCode = (int)(HttpStatusCode.InternalServerError);
            IsValid = false;
            Message = message;

            return this;
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
