using Microsoft.EntityFrameworkCore;
Console.WriteLine("Hallo wereld");

using (ApplicationDbContext ctx = new ApplicationDbContext())
{
    ctx.Students.Add(new Student("Arno", 69, "straat"));
    ctx.SaveChanges();
}


public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //SSMS login                  //Naam van DB                //Akkoord
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-HCUMO6M\SQLEXPRESS;Database=ApplicationDatabase;Trusted_Connection=True;");
        //////////////////////          ///////////////////                    ////
    }

    public DbSet<Student> Students { get; set; }
}
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
    public Student(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}