using BAMFHL.ViewModels;

namespace BAMFHL.Views;

public partial class WelcomePage : ContentPage
{
	public WelcomePage(WelcomeViewModel welcomeViewModel)
	{
		InitializeComponent();

		BindingContext = welcomeViewModel;
	}
}