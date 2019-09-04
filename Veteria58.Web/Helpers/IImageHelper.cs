using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Veteria58.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}