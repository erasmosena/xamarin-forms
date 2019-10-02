using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultarCep.Servico.Modelo
{
    public class Endereco
    {
        /// <summary>
        /// CEP
        /// </summary>
        public string Cep { get; set; }
        /// <summary>
        /// Logradouro
        /// </summary>
        public string  Logradouro { get; set; }
        /// <summary>
        /// Complemento
        /// </summary>
        public string Complemento { get; set; }
        /// <summary>
        /// Bairro
        /// </summary>
        public string Bairro { get; set; }
        /// <summary>
        /// Localidade
        /// </summary>
        public string Localidade { get; set; }
        /// <summary>
        /// UF
        /// </summary>
        public string Uf { get; set; }
        /// <summary>
        /// Unidade
        /// </summary>
        public string Unidade { get; set; }
        /// <summary>
        /// Ibge
        /// </summary>
        public string Ibge { get; set; }
        /// <summary>
        /// Gia
        /// </summary>
        public string Gia { get; set; }
        
    }
}
