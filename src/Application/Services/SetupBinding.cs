using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Interfaces;
using Gus;

namespace Application.Services
{
    public class SetupBinding : ISetupBinding
    {
        public void Binding(UslugaBIRzewnPublClient gusServices)
        {
            var enc = new MtomMessageEncodingBindingElement();
            var encoding = new MtomMessageEncodingBindingElement();
            var transport = new HttpsTransportBindingElement();

            var customBinding = new CustomBinding(encoding, transport);

            gusServices.Endpoint.Binding = customBinding;
        }
    }
}
