namespace CleanCodeExamples.Examples
{
    public class OneDotPerLine
    {
        public void Execute()
        {
            Student student = new Student();
            GraduatedStudent graduatedStudent = student.Graudate();

            if (graduatedStudent != null)
            {
                //action
            }
            string diploma = graduatedStudent.GiveDiploma();
            var isUtcnDiploma = diploma.Contains("UTCN");
        }
    }


    internal class Student
    {
        public GraduatedStudent Graudate()
        {
            return new GraduatedStudent();
        }
    }

    internal class GraduatedStudent
    {
        public string GiveDiploma()
        {
            return "foo";
        }
    }
}
