using AutoMapper;

namespace TestProject.Support.Mappers
{
    public class BookMappers
    {
        public BookAllInfoModel MappBookRegistrationModelToBookAllInfoModel (int id, BookRegistrationModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookRegistrationModel, BookAllInfoModel>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<BookAllInfoModel>(model);
            responseModel.Id = id;
            return responseModel;
        }

        public BookAllInfoModel MappBookUpdateModelToBookAllInfoModel(int id, BookUpdateModel model)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<BookUpdateModel, BookAllInfoModel>());
            Mapper mapper = new Mapper(config);
            var responseModel = mapper.Map<BookAllInfoModel>(model);
            responseModel.Id = id;
            return responseModel;
        }
    }
}
