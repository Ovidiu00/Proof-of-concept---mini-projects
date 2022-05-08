namespace CleanCodeExamples.Examples
{
    public class DontAddExtraInformation
    {
        public void Execute()
        {

        }


        class UserService
        {
            public void AddUser()
            {

            }
            public void DeleteUser()
            {

            }
            public void EditUser()
            {

            }
            public void GetUser()
            {

            }
        }

        class User
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
        }
    }
}
