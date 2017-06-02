using System.Web.Http;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WebApiServerDemo.Students.Dto;

namespace WebApiServerDemo.Students
{
	public interface IStudentAppService : IApplicationService
	{
		void DoProcess();

        void DoUnsupportedProcess();

        void CreateStudent(CreateStudentInput input);

        StudentOutput GetStudent(int id);

        ListResultDto<StudentDto> GetStudents(bool active);

        int? FindIdFromCode(string code);

        string FindCodeFromId(int id);

        bool ExistsStudent(string name, string surname);

        void UpdateStudents(BulkUpdateStudentInput input);

        void UpdateStudent(UpdateStudentInput input);

        void DeleteStudent(int id);

        void DeleteAllStudents();
	}
}
