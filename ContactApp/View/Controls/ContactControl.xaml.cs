namespace ContactApp.View.Controls;

public partial class ContactControl : ContentView
{

	public event EventHandler<string> onError;
	public event EventHandler<EventArgs> OnSave;
    public event EventHandler<EventArgs> OnCancel;
    public ContactControl()
	{
		InitializeComponent();
	}

	public string Name
	{
		get
		{
			return entryName.Text;
		}
		set
		{
			entryName.Text = value;
		}
	}

	public string Email
	{
		get
		{
			return entryEamil.Text;
		}
		set
		{
			entryEamil.Text = value;
		}
	}

	public string Phone
	{
		get
		{
			return entyPhone.Text;
		}
		set
		{
			entyPhone.Text = value;
		}
	}

    private void btnsaved_Clicked(object sender, EventArgs e)
    {
        if (nameValiditor.IsNotValid)
        {

			onError?.Invoke(sender, "Name is required");
            return;
        }

        if (emailvalidatior.IsNotValid)
        {
            foreach (var error in emailvalidatior.Errors)
            {
				onError?.Invoke(sender, error.ToString());
            }
            return;
        }
		OnSave?.Invoke(sender,e);
    }

    private void btncancel_Clicked(object sender, EventArgs e)
    {
		OnCancel?.Invoke(sender, e);
    }
}