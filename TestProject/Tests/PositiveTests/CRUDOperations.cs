using TestProject.Steps;
using TestProject.Support.Mappers;
using TestProject.Tests.TestSources;

namespace TestProject.Tests.PositiveTests
{
    public class CRUDOperations
    {
        private BookSteps _bookSteps;
        private BookMappers _bookMappers;
        private BookRegistrationModel _registerModel;
        private List<BookAllInfoModel> _allBooks;
        private int _bookId; 

        public CRUDOperations()
        {
            _bookSteps = new BookSteps();
            _bookMappers = new BookMappers();
        }

        [SetUp]
        public void Setup()
        {
            _allBooks = _bookSteps.GetAllBooks();
            _registerModel = new BookRegistrationModel()
            {
                Name = "Война и мир",
                Author = "Лев Толстой",
                Year = 1869,
                IsElectronicBook = false
            };
            _bookId = _bookSteps.RegisterBookTest(_registerModel);
        }

        [Test]
        public void CheckBooks_WhenBooksModelsIsCorrect_ShouldCheckBooks()
        {
            BookAllInfoModel additingBook = _bookMappers.MappBookRegistrationModelToBookAllInfoModel(_bookId, _registerModel);
            _allBooks.Add(additingBook);
            _bookSteps.CheckBooksTest(_allBooks);
        }

        [TestCaseSource(typeof(AddingBook_WhenBookModelIsCorrect_TestSourse))]
        public void RegisterBook_WhenBookModelIsCorrect_ShouldAddingBook()
        {
            int bookId = _bookSteps.RegisterBookTest(_registerModel);
            BookAllInfoModel expectedBook = _bookMappers.MappBookRegistrationModelToBookAllInfoModel(bookId, _registerModel);
            _bookSteps.FindAddedBookInListTest(expectedBook);
        }

        [TestCaseSource(typeof(EditBook_WhenBookModelIsCorrect_TestSourse))]
        public void EditBook_WhenBookModelIsCorrect_ShouldEditingBook(BookUpdateModel updateModel)
        {
            _bookSteps.UpdateBookTest(_bookId, updateModel);
            BookAllInfoModel expectedBook = _bookMappers.MappBookUpdateModelToBookAllInfoModel(_bookId, updateModel);
            _bookSteps.GetAllInfoBookByBookIdTest(_bookId, expectedBook);
        }

        [Test]
        public void DeleteBook_WhenBookIdIsCorrect_ShouldDeleteBook()
        {
            _bookSteps.DeleteBookTest(_bookId);
            BookAllInfoModel expectedBook = _bookMappers.MappBookRegistrationModelToBookAllInfoModel(_bookId, _registerModel);
            _bookSteps.FindDeletedBookInListTest(expectedBook);
        }
    }
}