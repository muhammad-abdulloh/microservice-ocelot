using Microsoft.AspNetCore.Mvc;
using StudentAdditionManagement.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentAdditionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StuedentAdmissionController : ControllerBase
    {
        // GET: api/<StuedentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionManagementDetailsModel> Get()
        {

            StudentAdmissionManagementDetailsModel student1 = new StudentAdmissionManagementDetailsModel
            {
                StudentId = 1,
                StudentName = "Sherbek",
                StudentClass = "B",
                DateOfJoining = DateTime.Now,
            };

            StudentAdmissionManagementDetailsModel student2 = new StudentAdmissionManagementDetailsModel
            {
                StudentId = 2,
                StudentName = "Farxod",
                StudentClass = "A",
                DateOfJoining = DateTime.Now,
            };

            List<StudentAdmissionManagementDetailsModel> list = new List<StudentAdmissionManagementDetailsModel>
            {
                student1,
                student2
            };

            return list;

        }

    }
}
