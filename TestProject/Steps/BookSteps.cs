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
            HttpStatusCode expectedRegistrationCode = HttpStatusCode.Created;
            HttpContent content = _booksClient.RegisterBook(model, expectedRegistrationCode);
            int actualId = Convert.ToInt32(content.ReadAsStringAsync().Result);
            Assert.NotNull(actualId);
            Assert.IsTrue(actualId > 0);
            return actualId;
        }

        public BookAllInfoModel GetAllInfoBookByBookIdTest(int id, BookAllInfoModel expectedBook)
        {
            HttpContent content = _booksClient.GetAllInfoBookByBookId(id, HttpStatusCode.OK);
            BookAllInfoModel actualBook = JsonSerializer.Deserialize<BookAllInfoModel>(content.ReadAsStringAsync().Result)!;
            Assert.AreEqual(expectedBook, actualBook);
            return actualBook;
        }

        public List<BookAllInfoModel> GetAllBooks()
        {
            HttpContent content = _booksClient.GetAllInfoBooks(HttpStatusCode.OK);
            List<BookAllInfoModel> actualBooks = JsonSerializer.Deserialize<List<BookAllInfoModel>>(content.ReadAsStringAsync().Result)!;
            return actualBooks;
        }

        public List<BookAllInfoModel> CheckBooksTest(List<BookAllInfoModel> expectedBooks)
        {
            HttpContent content = _booksClient.GetAllInfoBooks(HttpStatusCode.OK);
            List<BookAllInfoModel> actualBooks = JsonSerializer.Deserialize<List<BookAllInfoModel>>(content.ReadAsStringAsync().Result)!;
            CollectionAssert.AreEqual(actualBooks, expectedBooks);
            return actualBooks;
        }

        public void FindAddedBookInListTest(BookAllInfoModel expectedBook)
        {
            HttpContent content = _booksClient.GetAllInfoBooks(HttpStatusCode.OK);
            List<BookAllInfoModel> actualBooks = JsonSerializer.Deserialize<List<BookAllInfoModel>>(content.ReadAsStringAsync().Result)!;
            CollectionAssert.Contains(actualBooks, expectedBook);
        }

        public void FindDeletedBookInListTest(BookAllInfoModel expectedBook)
        {
            HttpContent content = _booksClient.GetAllInfoBooks(HttpStatusCode.OK);
            List<BookAllInfoModel> actualBooks = JsonSerializer.Deserialize<List<BookAllInfoModel>>(content.ReadAsStringAsync().Result)!;
            CollectionAssert.DoesNotContain(actualBooks, expectedBook);
        }

        public void UpdateBookTest(int id, BookUpdateModel model)
        {
            HttpStatusCode expectedUpdateCode = HttpStatusCode.NoContent;
            _booksClient.UpdateBookByBookId(id, model, expectedUpdateCode);
        }

        public void DeleteBookTest(int id)
        {
            HttpStatusCode expectedDeleteCode = HttpStatusCode.NoContent;
            _booksClient.DeleteBookByBookId(id, expectedDeleteCode);
        }
    }
}
