using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace WebApiServerDemo.Students.Dto
{
	public class UpdateStudentInput : IEntityDto
	{
		[Required]
		public int Id { get; set; }

		[Required, MaxLength(50)]
		public string Name { get; set; }

		[Required, MaxLength(50)]
		public string Surname { get; set; }

		[MaxLength(250)]
		public string Comment { get; set; }
	}
}
