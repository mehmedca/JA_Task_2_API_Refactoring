﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAP.Core.Models
{
    public class ActorModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public int PhotoId { get; set; }
        public string PhotoUrl { get; set; }

        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
        public string DeletedById { get; set; }
        public string CreatedByUsername { get; set; }
        public string ModifiedByUsername { get; set; }
        public string DeletedByUsername { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateDeleted { get; set; }

        public bool IsDeleted { get; set; }
    }
}
