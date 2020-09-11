using CinemaDatabase.Controller;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class CreateMovie
    {
        public static void View()
        {
            Application.Init();
            var top = Application.Top;

            var win = new Window(new Rect(0, 0, top.Frame.Width, top.Frame.Height), "Create Customer");
            top.Add(win);
            var titleField = new TextField(14, 2, 40, "");
            var priceField = new TextField(14, 4, 40, "");
            var createBtn = new Button(5, 8, "Create New Movie")
            {
                Clicked = () =>
                {
                    if (Utilities.FieldNotEmpty(titleField) && int.TryParse(Utilities.FieldString(priceField), out int price))
                    {
                        Create.Movie(Utilities.FieldString(titleField), price);
                        Application.RequestStop();
                    }
                    else
                    {
                        win.Add(new Label(3, 6, "Invalid Input..."));
                    }
                }
            };

            win.Add(
                new Label(3, 2, "Title: "),
                new Label(3, 4, "Price: "),
                titleField,
                priceField,
                createBtn
                );
            Application.Run();
        }
    }
}