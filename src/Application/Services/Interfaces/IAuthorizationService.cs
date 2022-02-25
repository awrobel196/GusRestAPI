using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gus;

namespace Application.Services.Interfaces
{
    public interface IAuthorizationService
    {
        void LoginIfRequired(string apiKey, UslugaBIRzewnPublClient gusServices);
        bool Login(string apiKey, UslugaBIRzewnPublClient gusServices);
        void Logout(UslugaBIRzewnPublClient gusServices);
    }
}
