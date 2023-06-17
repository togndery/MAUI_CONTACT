using ContactApp.View;

namespace ContactApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ContentPage), typeof(ContentPage));
        Routing.RegisterRoute(nameof(EditContactPage), typeof(EditContactPage));
        Routing.RegisterRoute(nameof(AddContactPage), typeof(AddContactPage));

    }
}
