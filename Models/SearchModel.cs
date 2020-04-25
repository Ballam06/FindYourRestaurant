﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindYourRestaurant.Models
{
    public class SearchModel
    {
        public List<SelectListItem> DrugDetails { get; set; }
        public int[] DrugIds { get; set; }
    }
}
}
