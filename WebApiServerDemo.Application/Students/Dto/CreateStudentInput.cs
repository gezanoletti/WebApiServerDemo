using System.ComponentModel.DataAnnotations;

namespace WebApiServerDemo.Students.Dto
{
	public class CreateStudentInput
	{
		[Required, MaxLength(50)]
		public string Name { get; set; }

		[Required, MaxLength(50)]
		public string Surname { get; set; }

		[MaxLength(250)]
		public string Comment { get; set; }
	}
}
