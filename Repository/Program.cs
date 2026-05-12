using Repository;

var repo = new RepositoryClass<Student, int>();

repo.Add(new Student { Id = 1, Name = "John", Lastname = "Doe" });
repo.Add(new Student { Id = 2, Name = "Jane", Lastname = "Smith" });

var student = repo.GetById(1);
var students = repo.GetAll();


var employeeRepo = new RepositoryClass<Employee, int>();

employeeRepo.Add(new Employee { Id = 1, Name = "Alice", Lastname = "Johnson", Salary = 50000 });

var emp = employeeRepo.GetAll();

Console.ReadKey();