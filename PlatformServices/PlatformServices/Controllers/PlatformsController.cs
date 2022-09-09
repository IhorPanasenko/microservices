using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformServices.Data;

namespace PlatformServices.Controllers
{
    public class PlatformsController : ControllerBase
    {
        public PlatformsController(IPlatformRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
