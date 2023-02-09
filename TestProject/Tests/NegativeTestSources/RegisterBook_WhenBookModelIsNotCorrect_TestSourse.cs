using System.Collections;

namespace TestProject.Tests.TestSources
{
    public class RegisterBook_WhenBookModelIsNotCorrect_TestSourse : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new BookRegistrationModel()
            {
                Name = null,
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = " ",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = " Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита ",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "-+/*!@#$%^&(){}[]<>,.':;",
                Author = "Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = " ",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = " Михаил Булгаков",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков ",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "-+/*!@#$%^&(){}[]<>,.':;",
                Year = 1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 01940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = -1940,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 2024,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = 2000000000,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = "Мастер и Маргарита",
                Author = "Михаил Булгаков",
                Year = (int)1940.4,
                IsElectronicBook = false
            };
            yield return new BookRegistrationModel()
            {
                Name = null,
                Author = null,
                Year = default,
                IsElectronicBook = default
            };
        }
    }
}
