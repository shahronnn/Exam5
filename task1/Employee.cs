namespace task1;

public class Employee
{
    int id;
    string firstname;
    string lastname;
    int salary;

    public Employee(){}
    public Employee(int id, string firstname, string lastname, int salary)
    {
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.salary = salary;
    }
    public int GetId()=> this.id;
    public string GetFirstName()=> this.firstname;
    public string GetLastName()=> this.lastname;
    public string GetName()=> $"{this.firstname} {this.lastname}";
    public int GetSalary()=> this.salary;
    public void SetSalary(int salary)=> this.salary = salary;
    public int GetAnualSalary()=> this.salary*12;
    public int RaiseSalary(int percent)=> salary+(this.salary*percent/100);
    public override string ToString()=> $"Employee[id={GetId()}, name={GetName()}, salary={GetSalary()}]";
}
