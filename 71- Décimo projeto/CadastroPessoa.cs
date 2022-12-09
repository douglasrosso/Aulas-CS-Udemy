using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace _71.Décimo_projeto
{
    [DataContract]

    internal class CadastroPessoa
    {

        // Atributos
        [DataMember]
        private string nome;
        [DataMember]
        private string numeroDoDocumento;
        [DataMember]
        private DateTime dataDeNascimento;
        [DataMember]
        private string nomeDaRua;
        [DataMember]
        private UInt32 numeroDaCasa;

        // Propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string NumeroDoDocumento
        {
            get { return numeroDoDocumento; }
            set { numeroDoDocumento = value; }
        }

        public DateTime DataDeNascimento
        {
            get { return dataDeNascimento; }
            set { dataDeNascimento = value; }
        }

        public string NomeDaRua
        {
            get { return nomeDaRua; }
            set { nomeDaRua = value; }
        }

        public UInt32 NumeroDaCasa
        {
            get { return numeroDaCasa; }
            set { numeroDaCasa = value; }
        }

        // Construtor
        public CadastroPessoa(string nome, string numeroDoDocumento, DateTime dataDeNascimento, string nomeDaRua, uint numeroDaCasa)
        {
            this.nome = nome;
            this.numeroDoDocumento = numeroDoDocumento;
            this.dataDeNascimento = dataDeNascimento;
            this.nomeDaRua = nomeDaRua;
            this.numeroDaCasa = numeroDaCasa;
        }
    }
}
