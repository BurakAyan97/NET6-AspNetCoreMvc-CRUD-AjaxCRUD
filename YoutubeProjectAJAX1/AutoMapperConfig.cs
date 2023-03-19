using AutoMapper;
using YoutubeProjectAJAX1.Entities;
using YoutubeProjectAJAX1.Models;

namespace YoutubeProjectAJAX1
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, CreateUserModel>().ReverseMap();
            CreateMap<User, EditUserModel>().ReverseMap();
        }
    }
}
