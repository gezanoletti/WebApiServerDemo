using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace WebApiServerDemo.Demo.Dto
{
	public class PersonDto : IEntityDto
	{
		public int Id { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }
	}
}
