using Terminal.Gui;

namespace CinemaDatabase.Views
{
    public static class PickUserType
    {
        public static int View() 
        {
            Application.Init();
            return MessageBox.Query(50, 7,
                "User Type", "Pick user type:", "Customer", "Admin");
        }       
    }
}
