using System.Collections.Generic;
using ApiProject.Data;
using ApiProject.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ApiProject.Dtos;


namespace ApiProject.Controllers
{

    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepo _repository;
        private readonly IMapper _mapper;

        public BooksController(IBookRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
       
        //GET api/books
        [HttpGet]
        public ActionResult <IEnumerable<BookReadDto>> GetAllBooks()
        {
            var books = _repository.GetAll();

            return Ok(_mapper.Map<IEnumerable<BookReadDto>>(books));
        }

        //GET api/books/{id}
        [HttpGet("{id}", Name="GetBookById")]
        public ActionResult <BookReadDto> GetBookById(int id)
        {
            var book = _repository.GetById(id);
            if(book != null)
            {
                return Ok(_mapper.Map<BookReadDto>(book));
            }
            return NotFound();
        }

        //POST api/books
        [HttpPost]
        public ActionResult <BookReadDto> CreateBook(BookCreateDto bookCreateDto)
        {
            var book = _mapper.Map<Book>(bookCreateDto);
            _repository.Create(book);
            _repository.SaveChanges();

            var bookReadDto = _mapper.Map<BookReadDto>(book);

            return CreatedAtRoute(nameof(GetBookById), new {Id = bookReadDto.Id}, bookReadDto);      
        }
        
    }
}