namespace GenericTypeExample
{
    public class Student
    {
        public Student(string fullName, byte grade, string speciality, string university )
        {
            FullName = fullName;
            Grade = grade;
            Speciality = speciality;
            University = university;
        }

        public string FullName { get; set; }
        // 1,2,3,4,5
        public byte Grade { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }
        public string University { get; set; }
    }
}
