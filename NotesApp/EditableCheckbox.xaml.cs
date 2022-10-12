namespace NotesApp.Controls;

public partial class EditableCheckbox : ContentView
{
	CheckBox checkBoxReference;
	Editor editorReference;

	public bool IsChecked { get; set; }
	public string Text { get; set; }

	public EditableCheckbox()
	{
		InitializeComponent();
	}
}