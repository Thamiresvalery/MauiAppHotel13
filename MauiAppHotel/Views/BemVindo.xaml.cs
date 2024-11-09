namespace MauiAppHotel.Views;

public partial class BemVindo : ContentPage
{
	public BemVindo()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new ContratacaoHospedagem());

		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}