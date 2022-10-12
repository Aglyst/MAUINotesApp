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

	private void Button_Clicked1(object sender, EventArgs e)
	{
        elements.Add(new Editor { Placeholder = count.ToString(), AutoSize=EditorAutoSizeOption.TextChanges, TextColor=Colors.Black });
		count += 1;
		Update();

    }

	private void Button_Clicked2(object sender, EventArgs e)
	{
        elements.Add(new Image { Source = "dotnet_bot.png", HeightRequest=30});
		Update();

    }

	private void Update()
	{
		VSLayout.Clear();
		foreach (IView element in elements)
		{
			VSLayout.Add(element);
			VSLayout.BackgroundColor = Color.FromRgba(r.NextDouble(), r.NextDouble(), r.NextDouble(), 1.0);
		}
	}
}

