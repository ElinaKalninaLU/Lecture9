using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Model
{
    public class dbContextCourses: DbContext
    {
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cs = ConfigurationManager.ConnectionStrings["MyCoursesConn"].ConnectionString;
            optionsBuilder.UseSqlServer(cs);
        }


    }
}
