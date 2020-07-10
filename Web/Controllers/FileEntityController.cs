using Application.Service;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileEntityController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileEntityController(IFileService fileService)
        {
            _fileService = fileService;
        }


    }
}