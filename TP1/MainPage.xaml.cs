namespace TP1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Evento disparado ao clicar no botão OK.
    /// Valida o ID e a Senha.
    /// </summary>
	private void OnOkButtonClicked(object sender, EventArgs e)
    {
        if (IdEntry.Text == "admin" && PassEntry.Text == "senha@dmin")
        {
            DisplayAlert("Login", "Logou com sucesso", "OK");
        }
        else
        {
            DisplayAlert("Login", "Login não autorizado", "OK");
        }
    }

    /// <summary>
    /// Evento disparado ao clicar no botão Limpar.
    /// Limpa os campos de texto e foca no campo de ID.
    /// </summary>
	private void OnLimparButtonClicked(object sender, EventArgs e)
    {
        IdEntry.Text = string.Empty;
        PassEntry.Text = string.Empty;

        IdEntry.Focus();
    }

    /// <summary>
    /// Evento disparado ao clicar no botão Créditos.
    /// Exibe os nomes dos autores.
    /// </summary> 
	private async void OnCreditosButtonClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Créditos", "Desenvolvido por:\n\n- Eduardo Barbosa Rodrigues\n- Vinicius Pontes Oliva", "Fechar");
    }
}