using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class PickCustomerActions
    {
        public static int View()
        {
            Application.Init();
            return MessageBox.Query(50, 7,
                "Customer Actions", "What do you wanna do?", "Order Tickets", "Show Bookings", "Edit Information", "Delete Customer","Exit");
            
        }
    }
}
