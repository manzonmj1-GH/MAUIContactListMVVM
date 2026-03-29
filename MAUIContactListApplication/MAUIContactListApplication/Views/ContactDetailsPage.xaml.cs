using MAUIContactListApplication.Models;
using Contact = MAUIContactListApplication.Models.Contact;
namespace MAUIContactListApplication.Views;

public partial class ContactDetailsPage : ContentPage
{
	public ContactDetailsPage(Contact contact)
	{
        InitializeComponent();
		BindingContext = contact;
	}

	private async void ReturnToPrevious(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}