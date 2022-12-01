using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace _56__Serialização_e_desserialização_de_classes
{
    [DataContract]

    internal class Cachorro
    {
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string raca;
        [DataMember]
        private string cor;

        public Cachorro(string pNome, string pRaca, string pCor) 
        {
            Nome = pNome;
            raca = pRaca;
            cor = pCor;
        }

        public Cachorro() 
        { 
        
        }

    }
}
