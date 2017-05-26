using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.WebApi.Controllers;
using WebApiServerDemo.Students;
using WebApiServerDemo.Students.Dto;

namespace WebApiServerDemo.Api.Controllers
{
	public class StudentController : AbpApiController
	{
		[HttpPost]
		public void DoProcess()
		{
			throw new NotImplementedException();
		}

		[HttpPost]
		public void DoUnsupportedProcess()
		{
			throw new NotImplementedException();
		}

		[HttpPost]
		public void CreateStudent(CreateStudentInput input)
		{
			throw new NotImplementedException();
		}

		[HttpGet]
		public StudentOutput GetStudent(int id)
		{
			return new StudentOutput
			{
				Student = new StudentDto
				{
					Id = 1,
					Code = "0001",
					Name = "No",
					Surname = "One"
				}
			};
		}

		[HttpGet]
		public ListResultDto<StudentDto> GetStudents(bool active)
		{
			return new ListResultDto<StudentDto>
			{
				Items = new List<StudentDto>
				{
					new StudentDto
					{
						Id = 1,
						Code = "0001",
						Name = "No",
						Surname = "One"
					},
					new StudentDto
					{
						Id = 2,
						Code = "0002",
						Name = "No",
						Surname = "One Too"
					},
				}
			};
		}

		[HttpGet]
		public int? FindIdFromCode(string code)
		{
			throw new NotImplementedException();
		}

		[HttpGet]
		public string FindCodeFromId(int id)
		{
			throw new NotImplementedException();
		}

		[HttpGet]
		public bool ExistsStudent(string name, string surname)
		{
			throw new NotImplementedException();
		}

		[HttpPut]
		public void UpdateStudents(BulkUpdateStudentInput input)
		{
			throw new NotImplementedException();
		}

		[HttpPut]
		public void UpdateStudent(UpdateStudentInput input)
		{
			throw new NotImplementedException();
		}

		[HttpDelete]
		public void DeleteStudent(int id)
		{
			throw new NotImplementedException();
		}

		[HttpDelete]
		public void DeleteAllStudents()
		{
			throw new NotImplementedException();
		}
	}
}
