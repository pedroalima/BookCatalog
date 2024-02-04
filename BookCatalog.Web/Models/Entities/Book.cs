using System;
using System.ComponentModel.DataAnnotations;

public class Book
{
	public Book()
	{
		public Guid Id { get; set; }
		public string Title { get; set; }
		public string Author { get; set; }

		[Range(1, 10, ErrorMessage = "A nota deve ser de 1 a 10")]
		public int Rating { get; set; }

	}
}
