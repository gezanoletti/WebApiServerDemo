using System.Web.Http;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WebApiServerDemo.Students.Dto;

namespace WebApiServerDemo.Students
{
	public interface IStudentAppService : IApplicationService
	{
		// POST students/{process_name}/start
		void DoProcess();

		// POST students/{process_name}/start
		void DoUnsupportedProcess();

		// POST /students
		StudentOutput CreateStudent(CreateStudentInput input);

		// GET /students/{id}
		StudentOutput GetStudent(int id);

		// GET /students/?active={active}
		ListResultDto<StudentDto> GetStudents([FromUri] bool active);

		// GET /students/id/{id}
		int? FindIdFromCode(string code);

		// GET /students/code/{code}
		string FindCodeFromId(int id);

		// GET /students/?name={}&surname={}
		bool ExistsStudent([FromUri] string name, [FromUri] string surname);

		// PUT /students
		void UpdateStudents(BulkUpdateStudentInput input);

		// PUT /students/{id}
		void UpdateStudent(UpdateStudentInput input);

		// DELETE /students/{id}
		void DeleteStudent(int id);

		// DELETE /students/
		void DeleteAllStudents();
	}
}
