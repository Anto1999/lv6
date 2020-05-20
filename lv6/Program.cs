using System;

namespace lv6
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            Note noteforremoval = null;

            for (int i = 0; i < 5; i++)
            {

                Note note = new Note("title" + i, "text" + i);
                notebook.AddNote(note);
                if (i == 3)
                {
                    noteforremoval = note;
                }

            }
            notebook.RemoveNote(noteforremoval);

        }
    }
}


