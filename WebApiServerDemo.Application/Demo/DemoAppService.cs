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
using WebApiServerDemo.Demo.Dto;

namespace WebApiServerDemo.Demo
{
	public class DemoAppService : ApplicationService, IDemoAppService
	{
		
		[AbpAuthorize]
		public void DoProcess()
		{

		}

		[AbpAuthorize]
		public bool ExistsPerson(PersonInput input)
		{
			//...
			return true;
		}

		[AbpAuthorize]
		public PersonOutput CreatePerson(PersonInput input)
		{
			return new PersonOutput
			{
				Person = new PersonDto
				{
					Id = 1,
					Code = "0001",
					Name = input.Name,
					Surname = input.Surname
				}
			};
		}

		[AbpAuthorize]
		public int? GetPersonIdFromCode(string input)
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
