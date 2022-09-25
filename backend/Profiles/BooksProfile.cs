using AutoMapper;
using ApiProject.Dtos;
using ApiProject.Models;

namespace ApiProject.Profiles
{
    public class BooksProfile : Profile
    {
        public BooksProfile()
        {
            CreateMap<Book, BookReadDto>()
                .ForMember(dest => dest.Author, act => act.MapFrom(src => src.FirstName + " " + src.LastName));

            CreateMap<BookCreateDto, Book>();
        }

    }
    
}