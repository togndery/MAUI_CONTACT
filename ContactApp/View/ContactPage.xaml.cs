using ContactApp.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace ContactApp.View;

public partial class ContactPage : ContentPage
{
	public ContactPage()
	{
		InitializeComponent();

       

    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContact();

    }




    private async void listContact_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if(listContact.SelectedItem != null)
		{
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((ContatcDetails)listContact.SelectedItem).Id}");
        }
	   
    }

    private void listContact_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		listContact.SelectedItem = null;
    }

    private async void btnAdd_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void aboutMenu_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("This App develop by", "Yehuda Tognder" + '\n' + "email:tognder@gmail.com", "OK");
    }

    private void mentDelete_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contatTodelte = menuItem.CommandParameter as ContatcDetails;
        ContactRepository.DelteItemFromList(contatTodelte.Id);

        LoadContact();
    }

    private void LoadContact()
    {
        var contactDetails = new ObservableCollection<ContatcDetails>(ContactRepository.GetContacts);
        listContact.ItemsSource = contactDetails;
    }

    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
       var result = new ObservableCollection<ContatcDetails>(ContactRepository.SearchItem(((SearchBar)sender).Text));
        listContact.ItemsSource = result;
    }

    private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {

    }
}