using MauiContactList.Models;
using System.Linq;

namespace MauiContactList.Views;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnChoiceChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection == null || !e.CurrentSelection.Any())
            return;

        var chosenContact = e.CurrentSelection.FirstOrDefault() as Contact;

        if (chosenContact == null)
            return;

        await Navigation.PushAsync(new Contact_Details_Page(chosenContact));

        // Clear selection to prevent re-triggering
        ((CollectionView)sender).SelectedItem = null;
    }
}