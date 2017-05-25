using Abp.Application.Services.Dto;

namespace WebApiServerDemo.Students.Dto
{
	public class StudentDto : IEntityDto
	{
		public int Id { get; set; }

		public string Code { get; set; }

		public string Name { get; set; }

		public string Surname { get; set; }

		public string Comment { get; set; }
	}
}
