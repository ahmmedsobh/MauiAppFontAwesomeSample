namespace MauiAppFontAwesomeSample;

public partial class MainPage : ContentPage
{
	public string smile { get; set; }
	public MainPage()
	{
		InitializeComponent();
		smile = "\uf118";
		BindingContext = this;
    }

	
}

