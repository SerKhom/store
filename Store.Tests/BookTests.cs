using System;
using Xunit;

namespace Store.Tests
{
	public class BookTests
	{
		[Fact]
		public void IsIsbn_WithNull_ReturnsFalse() {
			bool actual = Book.IsIsbn( null );

			Assert.False( actual );
		}

		[Fact]
		public void IsIsbn_WithBlankStrings_ReturnsFalse() {
			bool actual = Book.IsIsbn( "  " );

			Assert.False( actual );
		}

		[Fact]
		public void IsIsbn_WithInvalidIsbn_ReturnsFalse() {
			bool actual = Book.IsIsbn( "ISBN 123" );

			Assert.False( actual );
		}

		[Fact]
		public void IsIsbn_WithIsbn10_ReturnsTrue() {
			bool actual = Book.IsIsbn( "ISBN 123-456-789 0" );

			Assert.True( actual );
		}

		[Fact]
		public void IsIsbn_WithIsbn13_ReturnsTrue() {
			bool actual = Book.IsIsbn( "ISBN 123-456-789 0 123" );

			Assert.True( actual );
		}

		[Fact]
		public void IsIsbn_WithTrashStart_ReturnsFalse() {
			bool actual = Book.IsIsbn( "vbbvvb ISBN 123-456-789 0 123 lklkj" );

			Assert.False( actual );
		}
	}
}
