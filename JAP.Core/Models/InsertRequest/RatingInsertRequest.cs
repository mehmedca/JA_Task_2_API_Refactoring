﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.InsertRequest
{
    public class RatingInsertRequest
    {
        public int MovieId { get; set; }
        public int RatingInt { get; set; }
        public string RatedById { get; set; }
    }
}
