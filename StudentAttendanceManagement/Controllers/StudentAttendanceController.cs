using Microsoft.AspNetCore.Mvc;
using StudentAttendanceManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel studentObj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel studentObj2 = new StudentAttendanceDetailsModel();

            studentObj1.StudentId = 1;
            studentObj1.StudentName = "Muhammad Abdulloh";
            studentObj2.AttendancePercentage = 94.6;

            studentObj2.StudentId = 2;
            studentObj2.StudentName = "Jamshid";
            studentObj2.AttendancePercentage = 45.7;

            List<StudentAttendanceDetailsModel> listObj = new List<StudentAttendanceDetailsModel>
            {
                studentObj1,
                studentObj2
            };

            return listObj;
        }
    }
}
