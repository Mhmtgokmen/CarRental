using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        IWebHostEnvironment _webHostEnviroment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment webHostEnviroment)
        {
            _carImageService = carImageService;
            _webHostEnviroment = webHostEnviroment;
        }

        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetAllByCarId(int id)
        {
            var result = _carImageService.GetAllByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add1")]

        public  async Task<IActionResult> AddAsync([FromForm(Name =("Image"))] IFormFile file,[FromForm] CarImage carImage)
        {
            System.IO.FileInfo ınfo = new System.IO.FileInfo(file.FileName);
            string fileExtension = ınfo.Extension;

            var path = Path.GetTempFileName();
            if (file.Length > 0)
                using (var stream = new FileStream(path, FileMode.Create))
                    await file.CopyToAsync(stream);

            var carImag = new CarImage { CarId = carImage.CarId, ImagePath = path, Date = DateTime.Now };

            var result = _carImageService.Add(carImag, fileExtension);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]

        public IActionResult Add(CarImage carImage)
        {
            var result = _carImageService.Add(carImage," ");
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        public class FileUpload
        {
            public IFormFile files { get; set; }

            //public IFormFile carid { get; set; }
        }
        [HttpPost("add2")]
        public async Task<string> Add2([FromForm] FileUpload file,[FromForm]CarImage carImage)
        {
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.files.FileName);
            string fileExtension = fileInfo.Extension;

            var createdUniqueFileName = Guid.NewGuid().ToString("N")
                + "_" + DateTime.Now.Month + "_"
                + DateTime.Now.Day + "_"
                + DateTime.Now.Year + fileExtension;

            string path = _webHostEnviroment.WebRootPath + "\\uploads\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream fileStream=System.IO.File.Create(path+createdUniqueFileName))
            {
                await file.files.CopyToAsync(fileStream);
                
                fileStream.Flush();

            }

            await AddAsync(file.files, carImage);

            return "\\uploads\\" + createdUniqueFileName;
        }

        [HttpPost("update")]

        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageService.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageService.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
