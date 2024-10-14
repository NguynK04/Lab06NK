using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentService
    {

        private readonly StudentModel _context;
        public StudentService()
        {
            _context = new StudentModel(); // Khởi tạo context

        }

        public List<Student> getAll()
        {
            // Sử dụng _context đã được khởi tạo từ constructor
            return _context.Student.ToList();
        }
        public void Delete(int studentId)
        {
            var studentToDelete = _context.Student.Find(studentId);
            if (studentToDelete != null)
            {
                _context.Student.Remove(studentToDelete); // Xóa sinh viên
                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
        public void Update(Student student)
        {
            var existingStudent = _context.Student.Find(student.StudentID);
            if (existingStudent != null)
            {
                // Cập nhật các thuộc tính của sinh viên
                existingStudent.FullName = student.FullName;
                existingStudent.FacultyID = student.FacultyID;
                existingStudent.AverageScore = student.AverageScore;
                existingStudent.MajorID = student.MajorID;

                _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
            }
        }
        public void Add(Student student)
        {
            _context.Student.Add(student); // Thêm sinh viên vào DbSet
            _context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
        }

    }
}
