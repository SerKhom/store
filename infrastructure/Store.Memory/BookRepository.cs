namespace Store.Memory
{
	public class BookRepository : IBookRepository
	{
		private readonly Book[] books = new[]
		{
			new Book(1, "ISBN 12312-31231", "D. Knuth", "Art Of Programming", "Description 1", 12.78m),
			new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring", "Description 3", 17.80m),
			new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programming Language", "Description 7", 8.77m)
		};

		public Book[] GetAllByIsbn( string isbn ) {
			return books.Where( book => book.Isbn == isbn.ToUpper() )
				.ToArray();
		}

		public Book[] GetAllByTitleOrAuthor( string query ) {
			return books.Where(book => book.Author.Contains( query )
									|| book.Title.Contains( query ) )
				.ToArray();
		}

		public Book GetById( int id ) {
			return books.Single(book => book.Id == id);
		}
	}
}