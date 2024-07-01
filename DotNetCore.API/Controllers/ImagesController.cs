using AutoMapper;
using DotNetCore.API.Models.Domain;
using DotNetCore.API.Models.DTOs;
using DotNetCore.API.Repositories.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore.API.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ImagesController(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        //POST: /api/Images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromBody] ImageUploadRequestDto imageUploadRequest)
        {
            ValidateFileUpload(imageUploadRequest);
            if(ModelState.IsValid)
            {
                var localFilePath = Path.Combine(_webHostEnvironment.ContentRootPath, "Images", imageUploadRequest.FileName, Path.GetExtension(imageUploadRequest.File.FileName));

                var imageDomain = new Image
                {
                    File = imageUploadRequest.File,
                    FileName = imageUploadRequest.FileName,
                    FileDescription = imageUploadRequest.FileDescription,
                    FileExtemsion = Path.GetExtension(imageUploadRequest.File.FileName),
                    FileSizeInBytes = imageUploadRequest.File.Length,
                    FilePath = localFilePath
                };
                 using var stream = new FileStream(localFilePath, FileMode.Create, FileAccess.Write);
                //await Image.File.CopyToAsync(stream);

               //unitOfWork.Image.AddAsync(imageDomain); 

            }

            return BadRequest(ModelState);

        }

        private void ValidateFileUpload(ImageUploadRequestDto imageUploadRequest)
        {
            var allowedExtensions = new string[] { ".jpg", "jped", "png" };
            if (!allowedExtensions.Contains(Path.GetExtension(imageUploadRequest.File.Name)))
            {
                ModelState.AddModelError("file", "Unsupported file extension");
            }

            if( imageUploadRequest.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size more than 10MB, Please upload a smaller size file.");
            }

        }
    }
}
