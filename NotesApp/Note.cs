using NotesApp.Controls;

namespace NotesApp
{
    public class Note
    {
        public string Title { get; set; }
        public List<IView> elements = new List<IView>();

        public Note(string path)
        {
            // Deserialize Note
        }

        public void SerializeNote()
        {

        }
    }
}
