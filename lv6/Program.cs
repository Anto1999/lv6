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


             var date = new DateTime(2020, 5, 20, 19, 21, 10);

            ToDoItem item = new ToDoItem("Anto", "zadatak3", date);
            CareTaker careTaker = new CareTaker();
            careTaker.PushStack(item.StoreState());
            item.Rename("Ivic");
            item.ChangeTask("hehehe");
            item.RestoreState(careTaker.PopStack());

        }
    }
}


