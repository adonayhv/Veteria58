using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veteria58.Web.Helpers
{
  public  interface ICombosHelper
    {
         IEnumerable<SelectListItem> GetComboPetTypes();
    }
}
