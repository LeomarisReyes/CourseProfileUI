namespace CourseProfileUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new ViewModels.CourseProfileViewModel();
	}

}

