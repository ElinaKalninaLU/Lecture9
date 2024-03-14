// See https://aka.ms/new-console-template for more information
using DBFirst.Model;

Console.WriteLine("Hello, World!");

using (var dbc = new TestDbContext())
{
   int i =  dbc.Courses.Count();
    Console.WriteLine(i.ToString());
}

