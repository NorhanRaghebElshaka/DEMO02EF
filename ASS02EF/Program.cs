internal class Program
{
    private static void Main(string[] args)
    {
        #region TASK

        //////var newStudent = new Student { FName = "Ali", LName = "Ahmed", Address = "123 Street", Age = 21, Dep_Id = 1 };
        //////context.Students.Add(newStudent);
        //////context.SaveChanges();

        //////// Read
        //////var students = context.Students.ToList();
        //////Console.WriteLine("Students:");
        //////foreach (var student in students)
        //////{
        //////    Console.WriteLine($"{student.ID}: {student.FName} {student.LName}");
        //////}

        //////// Update
        //////var existingStudent = context.Students.FirstOrDefault(s => s.ID == newStudent.ID);
        //////if (existingStudent != null)
        //////{
        //////    existingStudent.Address = "456 Avenue";
        //////    context.SaveChanges();
        //////}

        //////// Delete
        //////context.Students.Remove(existingStudent);
        //////context.SaveChanges(); 
        #endregion

    }
}