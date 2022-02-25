using Gus;
using System.ServiceModel;
using System.ServiceModel.Channels;
using Application.Services.Interfaces;

namespace Application.Services
{
    

    public class AuthorizationService : IAuthorizationService
    {
        private string _sessionId;
        public AuthorizationService()
        {
            _sessionId = String.Empty;
        }

        public  void LoginIfRequired(string apiKey, UslugaBIRzewnPublClient gusServices)
        {
            string statuSesji = gusServices.GetValue("StatusSesji");

            if (statuSesji == "0") Login(apiKey, gusServices);
        }

        public bool Login(string apiKey, UslugaBIRzewnPublClient gusServices)
        {

            _sessionId = gusServices.Zaloguj(apiKey);

            if (String.IsNullOrEmpty(_sessionId)) return false;

            OperationContextScope scope = new OperationContextScope(gusServices.InnerChannel);
            HttpRequestMessageProperty requestProperties = new HttpRequestMessageProperty();
            requestProperties.Headers.Add("sid", _sessionId);
            OperationContext.Current.OutgoingMessageProperties[HttpRequestMessageProperty.Name] = requestProperties;
            return true;
        }

        public void Logout(UslugaBIRzewnPublClient gusServices)
        {
             gusServices.Wyloguj(_sessionId);
        }
    }
}
