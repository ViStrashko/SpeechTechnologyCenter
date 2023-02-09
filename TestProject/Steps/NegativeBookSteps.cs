using System.Net;
using TestProject.Client;

namespace TestProject.Steps
{
    public class NegativeBookSteps
    {
        private BooksClient _booksClient;

        public NegativeBookSteps()
        {
            _booksClient = new BooksClient();
        }

        public void RegisterBookWhenBookModelIsNotCorrectNegativeTest(BookRegistrationModel model)
        {
            _booksClient.RegisterBook(model, HttpStatusCode.UnprocessableEntity);
        }

        public void UpdateBookWhenBookModelIsNotCorrectNegativeTest(int id, BookUpdateModel model)
        {
            _booksClient.UpdateBookByBookId(id, model, HttpStatusCode.UnprocessableEntity);
        }

        public void UpdateBookWhenBookIdIsNotCorrectNegativeTest(int id, BookUpdateModel model)
        {
            _booksClient.UpdateBookByBookId(id, model, HttpStatusCode.BadRequest);
        }

        public void GetBookWhenBookIdIsNotCorrectNegativeTest(int id)
        {
            _booksClient.GetAllInfoBookByBookId(id, HttpStatusCode.BadRequest);
        }

        public void DeleteBookWhenBookIdIsNotCorrectNegativeTest(int id)
        {
            _booksClient.DeleteBookByBookId(id, HttpStatusCode.BadRequest);
        }

        public void DeleteBookWhenBookHasAlreadyBeenDeletedNegativeTest(int id)
        {
            _booksClient.DeleteBookByBookId(id, HttpStatusCode.NotFound);
        }
    }
}
