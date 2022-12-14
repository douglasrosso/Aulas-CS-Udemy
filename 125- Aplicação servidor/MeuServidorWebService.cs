using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace _125__Aplicação_servidor
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class MeuServidorWebService : IContratoServidor
    {
        ServiceHost serviceHost;
        public bool EnviaStringProServidor(string pMensagemEnviada)
        {
            Console.WriteLine(pMensagemEnviada);
            return true;
        }

        public string PegaStringDoServidor()
        {
            return "Mensagem do servidor para o cliente";
        }

        public MeuServidorWebService(string pURL)
        {
            Uri uri = new Uri(pURL);
            Console.WriteLine("Iniciando o servidor WebService...");
            serviceHost = new ServiceHost(this/* Objeto, servidor WebService, ou seja ele mesmo */, uri);
            ServiceMetadataBehavior smb = serviceHost.Description.Behaviors.Find<ServiceMetadataBehavior>();
            if (smb == null)
                smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            serviceHost.Description.Behaviors.Add(smb);
            serviceHost.AddServiceEndpoint(ServiceMetadataBehavior.MexContractName, MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            ServiceEndpoint ep = serviceHost.AddServiceEndpoint(typeof(IContratoServidor), new BasicHttpBinding(), uri);
            serviceHost.Open();
            Console.WriteLine($"Servidor iniciado em: {pURL}");
        
        }
    }
}
