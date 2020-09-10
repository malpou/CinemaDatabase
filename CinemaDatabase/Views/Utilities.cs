using System.Collections.Generic;
using CinemaDatabase.Controller;
using CinemaDatabase.Models;
using Terminal.Gui;

namespace CinemaDatabase.Views
{
    class Utilities
    {
        public static bool IsValidEmail(TextField textField)
        {
            string email = FieldString(textField);
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
             
        public static string CheckProp(string str)
        {
            return str != null ? str : "N/A";
        }

        public static bool FieldNotEmpty(TextField textField)
        {
            return FieldLength(textField) > 0;
        }

        public static bool FieldNotEmpty(TextField textField1, TextField textField2)
        {
            return FieldLength(textField1) > 0 && FieldLength(textField2) > 0;
        }

        public static string FieldString(TextField textField)
        {
            return textField.Text.ToString();
        }

        public static bool CheckId(TextField textField, out int number)
        {
            
            if (int.TryParse(FieldString(textField), out int n))
            {
                number = n;
                List<Movie> movies = Read.AllMovies();
                foreach (Movie movie in movies)
                {
                    if (number == movie.MovieId)
                    {
                        return true;
                    }
                }
            }
            number = 0;
            return false;
        }

        private static int FieldLength(TextField textField)
        {
            string str = FieldString(textField);
            return str.Length;
        }
    }
}
