namespace Day20DemoConsole;
public class Student
{
    #region Fields 
    // this region is just for design no requirement as such
    // variable , field and attributes are same
    int rollno;
    string name;
    string addr;
    #endregion

    /// <summary>
    /// default constructor for student class
    /// </summary>
    
 public Student()
    {
        rollno = 100;
        name ="Dummy";
        addr = "Dummy City";

    }
    public Student(int id , string name , string city)
    {
        rollno=id;
        this.name=name;
        addr=city;
    }
    public void DisplayDetails(Student s1)
    {
        System.Console.WriteLine("RollNo :{0}\n Name :{1}\n Address :{2}", s1.rollno,s1.name,s1.addr);
    }
}

