﻿using PromotionsWebApp.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionsWebApp.Domain.Entities
{
    public class Staff:BaseEntity
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int? ResumeId { get; set; }
        public Document Resume { get; set; }
    }
}
