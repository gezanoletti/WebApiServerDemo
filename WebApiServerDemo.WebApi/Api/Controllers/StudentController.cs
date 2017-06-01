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
    [RoutePrefix("api/students")]
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
        [Route("")]
        public void CreateStudent(CreateStudentInput input)
		{
			
		}
        
		[HttpGet]
        [Route("{id:int}")]
        public StudentOutput GetStudent(int id)
		{
			return new StudentOutput
			{
				Student = new StudentDto
				{
					Id = id,
					Code = "0001",
					Name = "No",
					Surname = "One"
				}
			};
		}
        
        [HttpGet]
        [Route("")]
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
        [Route("query/code/{code}")]
        public int? FindIdFromCode(string code)
		{
		    try
		    {
		        return Convert.ToInt32(code);
		    }
		    catch (Exception)
		    {
		        return null;
		    }
		}

		[HttpGet]
        [Route("query/id/{id}")]
        public string FindCodeFromId(int id)
		{
		    return id.ToString();
		}

		[HttpGet]
        [Route("query/name/{name}/surname/{surname}")]
        public bool ExistsStudent(string name, string surname)
		{
		    return "No".Equals(name) && "One".Equals(surname);
		}

		[HttpPatch]
        [Route("")]
        public void UpdateStudents(BulkUpdateStudentInput input)
		{
			
		}

		[HttpPut]
        [Route("")]
        public void UpdateStudent(UpdateStudentInput input)
		{
			
		}

		[HttpDelete]
        [Route("{id}")]
        public void DeleteStudent(int id)
		{
			throw new NotImplementedException();
		}

		[HttpDelete]
        [Route("")]
        public void DeleteAllStudents()
		{
			throw new NotImplementedException();
		}
	}
}
