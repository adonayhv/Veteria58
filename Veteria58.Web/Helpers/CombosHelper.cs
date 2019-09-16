using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veteria58.Web.Data;

namespace Veteria58.Web.Helpers
{
    public class CombosHelper : ICombosHelper
    {
        private readonly DataContext _dataContext;

        public CombosHelper(DataContext datacontex)
        {
            _dataContext = datacontex;
        }
        public IEnumerable<SelectListItem> GetComboPetTypes()

        {


            //var list = new List<SelectListItem>();
            //foreach (var petType in _datacontex.PetTypes)
            //{
            //    list.Add(new SelectListItem
            //    {
            //        Text = petType.Name,
            //        Value = $"{petType.Id}"
            //    });

            //}
            //esto sustituye a lo de arriba

            var list = _dataContext.PetTypes.Select(pt => new SelectListItem
            {
                Text=pt.Name,
                Value=$"{pt.Id}"
            })
                .OrderBy(pt=>pt.Text)
                .ToList();
            list.Insert(0, new SelectListItem
            {
                Text = "[Select a pet type]",
                Value="0"
            });
            return list;
        }

        public IEnumerable<SelectListItem> GetComboServiceTypes()
        {
            var list = _dataContext.ServiceTypes.Select(st => new SelectListItem
            {
                Text = st.Name,
                Value = $"{st.Id}"
            }).OrderBy(st => st.Text).ToList();


            list.Insert(0, new SelectListItem
            {
                Text = "(Select a service type...)",
                Value = "0"
            });

            return list;
        }


    }
}
