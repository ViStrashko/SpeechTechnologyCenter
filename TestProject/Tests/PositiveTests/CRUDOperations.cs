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
        private int _bookId; 

        public CRUDOperations()
        {
            _bookSteps = new BookSteps();
            _bookMappers = new BookMappers();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _registerModel = new BookRegistrationModel()
            {
                Name = "????? ? ???",
                Author = "??? ???????",
                Year = 1869,
                IsElectronicBook = false
            };
            _bookId = _bookSteps.RegisterBookTest(_registerModel);
        }

        [TestCaseSource(typeof(RegisterBook_WhenBookModelIsCorrectAndOptionalPropertiesIsNull_TestSourse))]
        public void RegisterBook_WhenBookModelIsCorrectAndOptionalPropertiesIsNull_ShouldAddingBook(BookRegistrationModel registerModel)
        {
            int bookId = _bookSteps.RegisterBookTest(registerModel);
            Book expectedBook = _bookMappers.MappBookRegistrationModelToBook(bookId, registerModel);
            _bookSteps.FindAddedBookInListTest(expectedBook);
        }

        [Test]
        public void CheckAddingBook_WhenBookModelAndBookIdIsCorrect_ShoulAdditingBook()
        {
            Book expectedBook = _bookMappers.MappBookRegistrationModelToBook(_bookId, _registerModel);
            _bookSteps.GetAllInfoBookByBookIdTest(_bookId, expectedBook);
        }

        [Test]
        public void CheckBooks_WhenGetSecondRequest_ShoulListsBooksIsSame()
        {
            AllBooksModel expectedBooks = _bookSteps.GetAllBooks();
            _bookSteps.GetAllBooksTest(expectedBooks);
        }

        [TestCaseSource(typeof(EditBook_WhenBookModelAndBookIdIsCorrect_TestSourse))]
        public void EditBook_WhenBookModelAndBookIdIsCorrect_ShouldEditingBook(BookUpdateModel updateModel)
        {
            _bookSteps.UpdateBookTest(_bookId, updateModel);
            AllInfoBookModel expectedBook = _bookMappers.MappBookUpdateModelToBookAllInfoModel(_bookId, updateModel);
            _bookSteps.GetAllInfoBookByBookIdTest(_bookId, expectedBook.Book);
        }

        [Test]
        public void DeleteBook_WhenBookIdIsCorrect_ShouldDeleteBook()
        {
            _bookSteps.DeleteBookTest(_bookId);
            Book expectedBook = _bookMappers.MappBookRegistrationModelToBook(_bookId, _registerModel);
            _bookSteps.FindDeletedBookInListTest(expectedBook);
        }
    }
}