namespace EmployeeList
{
    public class Employee
    {
       public string Name { get; set; }
       public int Id { get; set; }
       public double Salary { get; private set; }

       public Employee (int id, string name, double salary){

         Id = id;
         Name = name;
         Salary = salary;
       }

       public void IncreasySalary(double percentage){
         Salary += Salary * percentage / 100;
       }

        public override string ToString()
        {
            return Id
              + " , "
              + Name
              + " , "
              + Salary.ToString("F2");
            }
        }
      
     }

  

