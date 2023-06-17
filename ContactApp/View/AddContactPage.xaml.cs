using ContactApp.Models;

namespace ContactApp.View;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void contactUC_OnSave(object sender, EventArgs e)
    {
        var contact = new ContatcDetails
        {
            Name = contactUC.Name,
            Email = contactUC.Email,
            Phone = contactUC.Phone,
        };
        ContactRepository.AddContact(contact);

        Shell.Current.GoToAsync("..");
    }

    private void contactUC_OnCancel(object sender, EventArgs e)
    {
        Shell.Current?.GoToAsync("..");
    }

    private void contactUC_onError(object sender, string e)
    {
        DisplayAlert("Error", e, "OK");
    }
}