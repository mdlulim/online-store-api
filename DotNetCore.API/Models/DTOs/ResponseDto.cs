using System.ComponentModel.DataAnnotations;

namespace DotNetCore.API.Models.DTOs
{
    public class ResponseDto
    {
            public bool Success { get; set; }
            public string Message { get; set; }
            public object Data { get; set; }
    }
}
