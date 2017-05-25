using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp;
using Abp.Application.Services;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.Web.Models;
using WebApiServerDemo.Students;
using WebApiServerDemo.Students.Dto;

namespace WebApiServerDemo.Demo
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
		public StudentOutput CreateStudent(CreateStudentInput input)
		{
			return new StudentOutput
			{
				Student = new StudentDto
				{
					Id = 1,
					Code = "0001",
					Name = input.Name,
					Surname = input.Surname
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
		public void DoUnsupportedProcess()
		{
			throw new AbpException("Dont call this");
		}
	}
}
