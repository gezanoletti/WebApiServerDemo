using System.Web.Http;
using Abp.Application.Services;
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
