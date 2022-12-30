using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prj29bWebCoreMVC.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		
		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }
		public string? Genre { get; set; }
		public decimal Price { get; set; }
	}
}
