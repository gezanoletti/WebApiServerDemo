using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;

namespace WebApiServerDemo.Students.Dto
{
	public class BulkUpdateStudentInput
	{
		public bool Active { get; set; }

		[MaxLength(250)]
		public string Comment { get; set; }
	}
}
