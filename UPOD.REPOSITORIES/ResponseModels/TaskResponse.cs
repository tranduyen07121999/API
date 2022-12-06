﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPOD.REPOSITORIES.ResponseModels
{
    public class TaskResponse
    {
        public string? task { get; set; }
        public Guid id { get; set; }
        public string? code { get; set; }
        public string? name { get; set; }
        public string? status { get; set; }
        public string? customer_name { get; set; }
        public string? agency_name { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? update_date { get; set; }
    }
}
