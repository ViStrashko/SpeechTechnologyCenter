using System.Collections;

namespace TestProject.Tests.TestSources
{
    public class EditBook_WhenBookModelIsNotCorrect_TestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new BookUpdateModel()
            {
                Name = null,
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = " ",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = " Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита ",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "-+/*!@#$%^&(){}[]<>,.':;",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = null,
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = " ",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = " Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков ",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "-+/*!@#$%^&(){}[]<>,.':;",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = default,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 0,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 01940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = -1940,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 2024,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 2000000000,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = (int)1940.4,
                IsElectronicBook = false
            };
            yield return new BookUpdateModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = default
            };
            yield return new BookUpdateModel()
            {
                Name = null,
                Author = null,
                Year = default,
                IsElectronicBook = default
            };
        }
    }
}
