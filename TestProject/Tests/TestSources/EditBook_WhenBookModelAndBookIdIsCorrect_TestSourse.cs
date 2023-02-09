using System.Collections;

namespace TestProject.Tests.TestSources
{
    public class EditBook_WhenBookModelAndBookIdIsCorrect_TestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new BookUpdateModel()
            {
                Name = "Война или мир",
                Author = "Лев Толстой",
                Year = 1869,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Война и мир",
                Author = "Лева Толстой",
                Year = 1869,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Война и мир",
                Author = "Лев Толстой",
                Year = 1870,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Война и мир",
                Author = "Лев Толстой",
                Year = 1869,
                IsElectronicBook = true
            };
        }
    }
}
