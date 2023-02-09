using System.Collections;

namespace TestProject.Tests.TestSources
{
    public class AddingBook_WhenBookModelIsCorrect_TestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new BookRegistrationModel()
            {
                Name = "Жизнь взаймы",
                Author = null,
                Year = 1861,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Ревизор",
                Author = "Николай Гоголь",
                Year = null,
                IsElectronicBook = true
            };
            yield return new BookRegistrationModel()
            {
                Name = "Евгений Онегин",
                Author = "Александр Пушкин",
                Year = 1833,
                IsElectronicBook = null
            };
        }
    }
}
