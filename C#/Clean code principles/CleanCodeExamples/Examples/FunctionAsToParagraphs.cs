namespace CleanCodeExamples.Examples
{
    public class FunctionAsToParagraphs
    {
        public void CalculateStudentScholarShip(int studentId)
        {
            var student = GetStudent(studentId);
            var absences = GetAbsences(student);
            var grades = GetGrades(student);

            var scholarship = CalculateScholarShip(absences, grades);

        }

        private object GetStudent(int studentId)
        {
            //call to db to find student
            return null;
        }
        private object GetAbsences(object student)
        {
            //call to db to find student's absences
            return null;
        }
        private object CalculateScholarShip(object absences,object grades)
        {
            //formula for scholarship
            return null;
        }
        private object GetGrades(object student)
        {
            //call to db to find student's grades
            return null;
        }

    }
}
