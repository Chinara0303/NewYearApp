using NewYearApp.Controller;

#region Student
StudentController studentController = new();
//studentController.GetStudentCount();
//studentController.GetStudentAvgAge();
//studentController.GetStudentsEmailByFiltered();
//studentController.GetStudentsAddressByFiltered();
//studentController.SearchWithNameandSurname();
studentController.SearchWithStr();
//studentController.GetSameNameStudents();
#endregion

#region Fibonacci
FibonacciController fibonacciController = new FibonacciController();
//fibonacciController.GetFibNums();
#endregion

#region Calculate
CalculateController calculateController = new();
//calculateController.Calculation();
#endregion

#region Employee
EmployeeController employeeController = new();
//employeeController.GetEmployeesByFiltered();
#endregion