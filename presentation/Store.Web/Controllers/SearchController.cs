using Microsoft.AspNetCore.Mvc;
using Store.Memory;

namespace Store.Web.Controllers
{
	public class SearchController : Controller
	{
		private readonly IBookRepository bookRepository;

		public SearchController( ) {
			this.bookRepository = new BookRepository();
		}

 		public IActionResult Index(string query) {
			var books = bookRepository.GetByTitle( query );

			return View( books );
		}
	}
}
