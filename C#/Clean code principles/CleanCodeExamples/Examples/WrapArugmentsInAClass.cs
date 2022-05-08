using System.Collections.Generic;

namespace CleanCodeExamples.Examples
{
    class WrapArugmentsInAClass
    {

        public void execute()
        {
            //photos/docs etc
            var attachements = new List<string>();
            SendEmailArgs args = new SendEmailArgs("dorel@gmail.com", "@marinel@yahoo.com", "Hey its me", "Hi", attachements);

            SendMail(args);
        }
        private void SendMail(SendEmailArgs args)
        {
            //send
        }

        class SendEmailArgs
        {
            private string from;
            private string to;
            private string body;
            private string header;
            private List<string> attachements;

            public SendEmailArgs(string from, string to, string body, string header, List<string> attachements)
            {
                this.from = from;
                this.to = to;
                this.body = body;
                this.header = header;
                this.attachements = attachements;
            }
        }
    }
}
