using Microsoft.AspNetCore.Mvc;

namespace CopyPasteApi.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private static string _storedString = string.Empty;

        [HttpGet("paste")]
        public IActionResult Get()
        {
            return Ok(_storedString);
        }

        [HttpPut("copy")]
        public IActionResult Put([FromBody] string newValue)
        {
            if (string.IsNullOrWhiteSpace(newValue))
            {
                return BadRequest("Значение не должно быть пустым.");
            }

            _storedString = newValue;
            return Ok($"Новое значение установлено: {_storedString}");
        }
    }

}

