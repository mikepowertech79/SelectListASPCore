using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelectListASPCore.Models
{
    public class ViewModelCollege
    {
        public int Id { get; set; }

        public List<SelectListItem> strudents { get; set; }
    }
}
