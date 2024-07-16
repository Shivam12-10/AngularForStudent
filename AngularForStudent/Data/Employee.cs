namespace AngularForStudent.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }

    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

    }

}
