namespace CleanCodeExamples.Examples
{
    public class BooleansAsArguments
    {
        public void Execute()
        {
            bool isManager = true;
            string recipient = "Paul";

            if (isManager)
                SendFormalMail(recipient);
            else
                SendInFormalMail(recipient);
        }

        private void SendFormalMail(string recipient)
        {
            //send formal text as top of the morning
        }
        private void SendInFormalMail(string recipient)
        {
            //send informal text as yo 
        }

    }
}
