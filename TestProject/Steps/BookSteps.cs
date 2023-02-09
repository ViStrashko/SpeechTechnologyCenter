using System.Net;
using TestProject.Client;

namespace TestProject.Steps
{
    public class BookSteps
    {
        private BooksClient _booksClient;

        public BookSteps() 
        {
            _booksClient = new BooksClient();
        }

        public int RegisterBookTest(BookRegistrationModel model)
        {
            HttpContent content = _booksClient.RegisterBook(model, HttpStatusCode.Created);
            AllInfoBookModel actualBook = JsonSerializer.Deserialize<AllInfoBookModel>(content.ReadAsStringAsync().Result)!;
            Assert.NotNull(actualBook.Book.Id);
            Assert.IsTrue(actualBook.Book.Id > 0);
            return actualBook.Book.Id;
        }

        public AllInfoBookModel GetAllInfoBookByBookIdTest(int id, AllInfoBookModel expectedBook)
        {
            HttpContent content = _booksClient.GetAllInfoBookByBookId(id, HttpStatusCode.OK);
            AllInfoBookModel actualBook = JsonSerializer.Deserialize<AllInfoBookModel>(content.ReadAsStringAsync().Result)!;
            Assert.AreEqual(expectedBook, actualBook);
            return actualBook;
        }

        public void FindAddedBookInListTest(Book expectedBook)
        {
            HttpContent content = _booksClient.GetAllInfoBooks(HttpStatusCode.OK);
            AllIBooksModel actualBooks = JsonSerializer.Deserialize<AllIBooksModel>(content.ReadAsStringAsync().Result)!;
            if (expectedBook.Author == null)
                expectedBook.Author = "";
            else if (expectedBook.Id == null)
                expectedBook.Id = 0;
            else if (expectedBook.Year == null)
                expectedBook.Year = 0;
            CollectionAssert.Contains(actualBooks.Books, expectedBook);
        }

        public void FindDeletedBookInListTest(Book expectedBook)
        {
            HttpContent content = _booksClient.GetAllInfoBooks(HttpStatusCode.OK);
            AllIBooksModel actualBooks = JsonSerializer.Deserialize<AllIBooksModel>(content.ReadAsStringAsync().Result)!;
            CollectionAssert.DoesNotContain(actualBooks.Books, expectedBook);
        }

        public void UpdateBookTest(int id, BookUpdateModel model)
        {
            _booksClient.UpdateBookByBookId(id, model, HttpStatusCode.NoContent);
        }

        public void DeleteBookTest(int id)
        {
            _booksClient.DeleteBookByBookId(id, HttpStatusCode.NoContent);
        }
    }
}
