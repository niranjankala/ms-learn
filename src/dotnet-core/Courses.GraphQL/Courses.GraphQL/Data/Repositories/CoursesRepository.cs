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
            var newCourse = new Course()
            {
                Name = course.Name,
                Description = course.Description,
                DateAdded = course.DateAdded,
                DateUpdated = course.DateUpdated
            };
            _context.Courses.Add(newCourse);
            _context.SaveChanges();

            foreach (var review in course.Reviews)
            {
                var newReview = new Review()
                {
                     Rate = review.Rate,
                     Comment = review.Comment,
                     CourseId = newCourse.Id
                };
                _context.Reviews.Add(newReview);
                _context.SaveChanges();
            }
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
