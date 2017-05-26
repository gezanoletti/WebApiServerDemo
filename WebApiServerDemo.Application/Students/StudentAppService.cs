using System;
using System.Collections.Generic;
using Abp;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using WebApiServerDemo.Students.Dto;

namespace WebApiServerDemo.Students
{
	public class StudentAppService : ApplicationService, IStudentAppService
	{
		
		[AbpAuthorize]
		public void DoProcess()
		{

		}

		[AbpAuthorize]
		public bool ExistsStudent(CreateStudentInput input)
		{
			//...
			return true;
		}

		[AbpAuthorize]
		public void CreateStudent(CreateStudentInput input)
		{
			//...
		}

        [AbpAuthorize]
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

        [AbpAuthorize]
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

	    [AbpAuthorize]
		public int? FindIdFromCode(string input)
		{
			if ("0001".Equals(input))
			{
				return 1;
			}
			else
			{
				return null;
			}
		}

        [AbpAuthorize]
        public string FindCodeFromId(int id)
	    {
	        throw new NotImplementedException();
	    }

        [AbpAuthorize]
        public bool ExistsStudent(string name, string surname)
	    {
	        throw new NotImplementedException();
	    }

        [AbpAuthorize]
        public void UpdateStudents(BulkUpdateStudentInput input)
	    {
	        throw new NotImplementedException();
	    }

        [AbpAuthorize]
        public void UpdateStudent(UpdateStudentInput input)
	    {
	        throw new NotImplementedException();
	    }

        [AbpAuthorize]
        public void DeleteStudent(int id)
	    {
	        throw new NotImplementedException();
	    }

        [AbpAuthorize]
        public void DeleteAllStudents()
	    {
	        throw new NotImplementedException();
	    }

	    [AbpAuthorize]
		public void DoUnsupportedProcess()
		{
			throw new AbpException("Dont call this");
		}
	}
}
