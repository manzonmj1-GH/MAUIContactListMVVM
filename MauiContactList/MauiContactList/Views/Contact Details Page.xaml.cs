using MauiContactList.Models;

namespace MauiContactList.Views;

public partial class Contact_Details_Page : ContentPage
{
	public Contact_Details_Page(Models.Contact contact)
	{
		InitializeComponent();
		BindingContext = contact;
	}

	private async void ReturnToPrevious(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}