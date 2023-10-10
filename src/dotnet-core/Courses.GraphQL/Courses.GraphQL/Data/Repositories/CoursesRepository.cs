using Courses.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Courses.GraphQL.Data.Repositories
{
    public class CoursesRepository
    {
        private readonly AppDbContext _context;
        public CoursesRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Course> GetAllCourses()
        {
            return _context.Courses.Include(x => x.Reviews).ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.FirstOrDefault(n => n.Id == id);
        }
        public Course AddCourse(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
            return course;
        }

        public Course UpdateCourse(int id, Course course)
        {
            var _course = _context.Courses.FirstOrDefault(n => n.Id == id);
            _course.Name = course.Name;
            _course.Description = course.Description;
            //_course.Review = course.Review;
            _course.DateUpdated = DateTime.Now;
            _context.SaveChanges();

            return course;
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.FirstOrDefault(n => n.Id == id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }
    }
}
