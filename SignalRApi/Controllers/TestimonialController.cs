using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
                 Comment = createTestimonialDto.Comment,
                 Title = createTestimonialDto.Title,
                 ImageUrl = createTestimonialDto.ImageUrl,
                 Name = createTestimonialDto.Name,
                 Status = createTestimonialDto.Status,
            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id) 
        {
            var value = _testimonialService.TGetById(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");

        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                TestimonialId=updateTestimonialDto.TestimonialId,
                Comment = updateTestimonialDto.Comment,
                Title = updateTestimonialDto.Title,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name,
                Status = updateTestimonialDto.Status,
            });
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }
    }
}
