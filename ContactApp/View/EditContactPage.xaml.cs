using ContactApp.Models;


namespace ContactApp.View;

[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactPage : ContentPage
{
	private ContatcDetails _details;
	public EditContactPage()
	{
		InitializeComponent();
	}

    private async void btnback_Clicked(object sender, EventArgs e)
    {
	   await Shell.Current.GoToAsync("..");
    }

	public string ContactId
	{
		set
		{
			_details = ContactRepository.GetById(int.Parse(value));
			contactUC.Name = _details.Name;
			contactUC.Email = _details.Email;
			contactUC.Phone = _details.Phone;
		}
	}

    private void Update_Clicked(object sender, EventArgs e)
    {

		
        _details.Name = contactUC.Name;
		_details.Email = contactUC.Email;
		ContactRepository.UpdateContatcDetails(_details.Id,_details);
        Shell.Current.GoToAsync("..");
    }

    private void contactUC_onError(object sender, string e)
    {
		DisplayAlert("Error", e, "OK");
    }
}