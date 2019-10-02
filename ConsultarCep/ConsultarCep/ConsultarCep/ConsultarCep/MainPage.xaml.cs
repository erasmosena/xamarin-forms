using System;
using System.ComponentModel;
using Xamarin.Forms;
using ConsultarCep.Servico.Modelo;
using ConsultarCep.Servico;

namespace ConsultarCep
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Botao.Clicked += BOTAO_Clicked;
        }

        private void BOTAO_Clicked(object sender, EventArgs e)
        {
            try
            {
                string cep = Cep.Text.Trim();
                if (CepValido(cep))
                {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        Resultado.Text = String.Format("Endereço:  {0},{1} - {2}/{3}", end.Logradouro, end.Bairro, end.Localidade, end.Uf);
                    }
                    else {
                        DisplayAlert("Cep não encontrado", string.Format("Não foi possível localizar o cep: {0}.",cep), "Ok");
                    }
                }
            }
            catch (Exception ex) {
                DisplayAlert("Erro Crítico", "Ocorreu algum erro ao conectar ao serviço", "Ok");
            }
        }

        private bool CepValido(string cep)
        {
            bool valido = true;
            if (cep.Length != 8) {
                valido = false;
                DisplayAlert("Erro", "CEP inválido! O CEP deve conter 8 caracteres","OK");
            }
            int NovoCEP = 0;
            if (!int.TryParse(cep, out NovoCEP)) {
                valido = false;
                DisplayAlert("Erro", "CEP inválido! O CEP deve ser composto apenas por números", "OK");
            }
            return valido;
        }
    }
}
