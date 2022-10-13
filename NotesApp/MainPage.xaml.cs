using NotesApp.Controls;

namespace NotesApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	Random r = new Random();

	List<IView> elements = new List<IView>();

	public MainPage()
	{
		InitializeComponent();


	}

	private async void Button_Clicked1(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new NotePage(new Note("Placeholder")));
    }
}

