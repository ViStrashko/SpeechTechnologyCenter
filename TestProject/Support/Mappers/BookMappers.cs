using AutoMapper;

namespace TestProject.Support.Mappers
{
    public class BookMappers
    {
        public Book MappBookRegistrationModelToBook(int id, BookRegistrationModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookRegistrationModel, Book>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<Book>(model);
            responseModel.Id = id;
            return responseModel;
        }

        public AllInfoBookModel MappBookUpdateModelToBookAllInfoModel(int id, BookUpdateModel model)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AllInfoBookModel, BookUpdateModel>()
                .ForMember(pts => pts.Author, opt => opt.MapFrom(ps => ps.Book!.Author))
                .ForMember(pts => pts.Name, opt => opt.MapFrom(ps => ps.Book!.Name))
                .ForMember(pts => pts.Year, opt => opt.MapFrom(ps => ps.Book!.Year))
                .ForMember(pts => pts.IsElectronicBook, opt => opt.MapFrom(ps => ps.Book!.IsElectronicBook))
                .ReverseMap();
            });
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<AllInfoBookModel>(model);
            responseModel.Book.Id = id;
            return responseModel;
        }
    }
}
