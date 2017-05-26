using System.Web.Http;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WebApiServerDemo.Students.Dto;

namespace WebApiServerDemo.Students
{
	public interface IStudentAppService : IApplicationService
	{
		// POST students/{process_name}/start
        [HttpPost]
		void DoProcess();

        // POST students/{process_name}/start
        [HttpPost]
        void DoUnsupportedProcess();

        // POST /students
        [HttpPost]
        [ActionName("students")]
        void CreateStudent(CreateStudentInput input);

        // GET /students/{id}
        [HttpGet]
        StudentOutput GetStudent(int id);

        // GET /students/?active={active}
        [HttpGet]
        [ActionName("students")]
        ListResultDto<StudentDto> GetStudents([FromUri] bool active);

        // GET /students/id/{id}
        [HttpGet]
        int? FindIdFromCode(string code);

        // GET /students/code/{code}
        [HttpGet]
        string FindCodeFromId(int id);

        // GET /students/?name={}&surname={}
        [HttpGet]
        bool ExistsStudent([FromUri] string name, [FromUri] string surname);

        // PUT /students
        [HttpPut]
        void UpdateStudents(BulkUpdateStudentInput input);

        // PUT /students/{id}
        [HttpPut]
        void UpdateStudent(UpdateStudentInput input);

        // DELETE /students/{id}
        [HttpDelete]
        void DeleteStudent(int id);

        // DELETE /students/
        [HttpDelete]
        void DeleteAllStudents();
	}
}
