using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Web.Models;
using WebApiServerDemo.Demo.Dto;

namespace WebApiServerDemo.Demo
{
	public interface IDemoAppService : IApplicationService
	{
		void DoProcess();

		bool ExistsPerson(PersonInput input);

		PersonOutput CreatePerson(PersonInput input);

		int? GetPersonIdFromCode([FromUri] string input);

		void DoUnsupportedProcess();
	}
}
