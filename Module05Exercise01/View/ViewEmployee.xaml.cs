using Module05Exercise01.Services;
using Module05Exercise01.ViewModel;

namespace Module05Exercise01.View;

public partial class ViewEmployee : ContentPage
{
	public ViewEmployee()
	{
		InitializeComponent();

        var personalViewModel = new EmployeeViewModel();
        BindingContext = personalViewModel;
    }

    private async void OnBackHome(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//MainPage");
    }
}