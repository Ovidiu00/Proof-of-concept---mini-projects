namespace CleanCodeExamples.Examples
{
    public class HonestFunction
    {
        public static void Main(string[] args)
        {
            var loggedIn = LogInUser("username", "parola");

            if (loggedIn)
                RedirectToHome();
        }

        private static bool LogInUser(string user,string parola)
        {
            var success = CheckCredentials(user, parola);
            return success;              
        }
        private static bool CheckCredentials(string user,string parola)
        {
            return true;
        }
        private static void RedirectToHome()
        {

        }

    }
}
