using TestProject.Steps;
using TestProject.Support.Mappers;
using TestProject.Tests.TestSources;

namespace TestProject.Tests.NegativeTests
{
    public class CRUDOperations
    {
        private BookSteps _bookSteps;
        private NegativeBookSteps _negativeBookSteps;
        private BookMappers _bookMappers;
        private BookRegistrationModel _registerModel;
        private int _bookId;

        public CRUDOperations()
        {
            _bookSteps = new BookSteps();
            _negativeBookSteps = new NegativeBookSteps();
            _bookMappers = new BookMappers();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _registerModel = new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            _bookId = _bookSteps.RegisterBookTest(_registerModel);
        }

        [TestCaseSource(typeof(RegisterBook_WhenBookModelIsNotCorrect_TestSourse))]
        public void RegisterBook_WhenBookModelIsNotCorrect_ShouldGetHttpStatusCodeUnprocessableEntity
            (BookRegistrationModel registerModel)
        {
            _negativeBookSteps.RegisterBookWhenBookModelIsNotCorrectNegativeTest(registerModel);
        }

        [TestCaseSource(typeof(EditBook_WhenBookModelIsNotCorrect_TestSourse))]
        public void EditBook_WhenBookModelIsNotCorrect_ShouldGetHttpStatusCodeUnprocessableEntity(BookUpdateModel updateModel)
        {
            _negativeBookSteps.UpdateBookWhenBookModelIsNotCorrectNegativeTest(_bookId, updateModel);
        }

        [TestCase(-2)]
        [TestCase(0)]
        public void EditBook_WhenBookIdIsNotCorrect_ShouldGetHttpStatusCodeBadRequest(int id)
        {
            BookUpdateModel updateModel = _bookMappers.MappBookRegistrationModelToMappBookRegistrationModel(_registerModel);
            _negativeBookSteps.UpdateBookWhenBookIdIsNotCorrectNegativeTest(id, updateModel);
        }

        [TestCase(-2)]
        [TestCase(0)]
        public void CheckBook_WhenBookIdIsNotCorrect_ShouldGetHttpStatusCodeBadRequest(int id)
        {
            _negativeBookSteps.GetBookWhenBookIdIsNotCorrectNegativeTest(id);
        }

        [TestCase(-2)]
        [TestCase(0)]
        public void DeleteBook_WhenBookIdIsNotCorrect_ShouldGetHttpStatusCodeBadRequest(int id)
        {
            _negativeBookSteps.DeleteBookWhenBookIdIsNotCorrectNegativeTest(id);
        }

        [Test]
        public void DeleteBook_WhenBookHasAlreadyBeenDeleted_ShouldGetHttpStatusCodeNotFound()
        {
            _bookSteps.DeleteBookTest(_bookId);
            _negativeBookSteps.DeleteBookWhenBookHasAlreadyBeenDeletedNegativeTest(_bookId);
        }
    }
}
