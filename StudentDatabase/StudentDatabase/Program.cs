using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    public class Post
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float GPA { get; set; }
    }
    public class StudentDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
