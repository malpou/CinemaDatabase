using System;
using System.Collections.Generic;
using System.Text;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class PickStart
    {
        public static int View()
        {
            Application.Init();
            return MessageBox.Query(50, 7,
                "Cinema Database", "What do you wanna do?", "Open Program", "Close Program");
        }
    }
}
