namespace buscaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGerar_Click(object sender, EventArgs e)
        {
            string cep = txtCEP.Text.Trim();

            if (!string.IsNullOrEmpty(cep))
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string url = $"https://viacep.com.br/ws/{cep}/xml/";
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode)
                        {
                            string xmlResponse = await response.Content.ReadAsStringAsync();
                            // Aqui voc� pode processar o xmlResponse e exibir as informa��es no Label
                            lblResultado.Text = xmlResponse;
                        }
                        else
                        {
                            lblResultado.Text = "Erro ao obter as informa��es do CEP.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblResultado.Text = $"Erro: {ex.Message}";
                }
            }
            else
            {
                lblResultado.Text = "Por favor, digite um CEP v�lido.";
            }
        }
    }
}




