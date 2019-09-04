using System.Threading.Tasks;
using Veteria58.Web.Data.Entities;
using Veteria58.Web.Models;

namespace Veteria58.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Pet> ToPetAsync(PetViewModel model, string path, bool isNew);
        PetViewModel ToPetViewModel(Pet pet);
    }
}