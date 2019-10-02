using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using ConsultarCep.Servico.Modelo;
using Newtonsoft.Json;


namespace ConsultarCep.Servico
{
    public class ViaCEPServico
    {
        private static string _enderecoURL = "https://viacep.com.br/ws/{0}/json/";
        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string NovoEnderecoURL = string.Format(_enderecoURL, cep);
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NovoEnderecoURL);
            Endereco ende = JsonConvert.DeserializeObject<Endereco>(conteudo);
            if (ende.Cep == null) return null;
            return ende;
        }
    }
}
