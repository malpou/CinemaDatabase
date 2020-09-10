using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class PickAdminActions
    {
        public static int View()
        {
            Application.Init();
            return MessageBox.Query(50, 7,
                "Pick Task", "What do you wanna do?", "Create Movie", "Show Customers", "Exit");
        }
    }
}