namespace Store.Memory
{
	public class BookRepository : IBookRepository
	{
		private readonly Book[] books = new[]
		{
			new Book(1, "ISBN 12312-31231", "D. Knuth", "Art Of Programing"),
			new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring"),
			new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programing Language")
		};

		public Book[] GetAllByIsbn( string isbn ) {
			throw new NotImplementedException();
		}

		public Book[] GetAllByTitleOrAuthor( string titlePart ) {
			return books.Where(book => book.Title.Contains(titlePart))
				.ToArray();
		}
	}
}