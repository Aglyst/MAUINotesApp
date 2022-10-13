using NotesApp.Controls;

namespace NotesApp;


public partial class NotePage : ContentPage
{
	Note note;
    int count = 0;

    Random r = new Random();

	public NotePage(Note n)
	{
		InitializeComponent();

		note = n;
	}
    private void AddText(object sender, EventArgs e)
    {
        note.elements.Add(new Editor { Placeholder = count.ToString(), AutoSize = EditorAutoSizeOption.TextChanges, TextColor = Colors.Black });
        count += 1;
        Update();

    }

    private void AddImage(object sender, EventArgs e)
    {
        note.elements.Add(new Image { Source = "dotnet_bot.png", HeightRequest = 30 });
        Update();
    }

    private void AddCheckbox(object sender, EventArgs e)
    {
        note.elements.Add(new EditableCheckbox());
        Update();
    }

    private void Update()
    {
        ElementLayout.Clear();
        foreach (IView element in note.elements)
        {
            ElementLayout.Add(element);
            ElementLayout.BackgroundColor = Color.FromRgba(r.NextDouble(), r.NextDouble(), r.NextDouble(), 1.0);
        }
    }

}