using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class PickNewOrOldCustomer
    {
        public static int View()
        {
            Application.Init();
            return MessageBox.Query(50, 7,
                "Login or Create New User", "What do you wanna do?", "Login", "Create New User");
        }
    }
}
