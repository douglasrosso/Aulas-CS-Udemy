﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Runtime.Serialization;
using System.Threading;

namespace _103__CadastroBiblioteca
{
    public class Serializador
    {
        static private DataContractSerializer serializador = new DataContractSerializer(typeof(BaseDeDados));

        public static void Serializa(string pCaminhoArquivoXml, BaseDeDados pBaseDeDados)
        {
            XmlWriterSettings xmlConfig = new XmlWriterSettings { Indent = true };
            StringBuilder construtorDeString = new StringBuilder();
            XmlWriter escritorDeXml = XmlWriter.Create(construtorDeString, xmlConfig);
            serializador.WriteObject(escritorDeXml, pBaseDeDados);
            escritorDeXml.Flush();
            string objetoSerializadorStr = construtorDeString.ToString();

            FileStream meuArquivoXml = File.Create(pCaminhoArquivoXml);
            meuArquivoXml.Close();
            File.WriteAllText(pCaminhoArquivoXml, objetoSerializadorStr);
            escritorDeXml.Close();
        }

        public static BaseDeDados Desserializa(string pCaminhoArquivoXml)
        {
            try
            {
                if (File.Exists(pCaminhoArquivoXml))
                {
                    string conteudoDoObjetoSerializado = File.ReadAllText(pCaminhoArquivoXml);
                    StringReader leitorDeString = new StringReader(conteudoDoObjetoSerializado);
                    XmlReader leitorDeXml = XmlReader.Create(leitorDeString);
                    BaseDeDados baseDeDadosTemp = (BaseDeDados)serializador.ReadObject(leitorDeXml);
                    return baseDeDadosTemp;
                }
                else
                    return null;
            }
            catch
            {
                return null;
            }

        }

    }
}
