﻿using JAP.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models.SearchRequest
{
    public class ActorSearchRequest : BaseSearch
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
