namespace NotesApp.Controls;

public partial class EditableCheckbox : ContentView
{
	public bool IsChecked { get; set; }
	public string Text { get; set; }

	public EditableCheckbox()
	{
		InitializeComponent();
	}
}