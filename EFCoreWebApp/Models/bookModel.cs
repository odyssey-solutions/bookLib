using BookLibrary;

namespace EFCoreWeb.Models;

public static class bookModelExtentions
{
	public static IQueryable<bookModel> toModel(this IQueryable<Book> source)
	{
		return source.Select(b => new bookModel
		{
			Id = b.Id,
			Title = b.Title ?? "",
			YearOfPublication = b.YearOfPublication,
			Author = (b.Author != null) ? (b.Author.Name ?? "") : ""
		});
	}
}

public class bookModel
{
	public int		Id { get; set; }
	public string	Title { get; set; }
	public int		YearOfPublication { get; set; }
	public string 	Author { get; set; }

	public bookModel()
	{
	}
}