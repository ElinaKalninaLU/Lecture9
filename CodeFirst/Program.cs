// See https://aka.ms/new-console-template for more information
using CodeFirst.Model;

Console.WriteLine("Hello, World!");

using (var dbc = new dbContextCourses())
{
    int i = dbc.Courses.Count();
    Console.WriteLine(i.ToString());

    var c = new Course();
    c.Description = "Example";
    c.Name = ".NET";
    dbc.Courses.Add(c);
    dbc.SaveChanges();

     i = dbc.Courses.Count();
    Console.WriteLine(i.ToString());

}
