﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPOD.REPOSITORIES.Models;
using UPOD.REPOSITORIES.ResponseViewModel;

namespace UPOD.REPOSITORIES.ResponseModels
{
    public class RequestResponse
    {
        public Guid id { get; set; }
        public string? code { get; set; }
        public string? request_name { get; set; }
        public int? priority { get; set; }
        public string? request_status { get; set; }
        public string? description { get; set; }
        public DateTime? create_date { get; set; }
        public DateTime? update_date { get; set; }
        public Guid? create_by { get; set; } = null!;
        public CustomerViewResponse customer { get; set; } = null!;
        public AgencyViewResponse agency { get; set; } = null!;
        public ServiceViewResponse service { get; set; } = null!;
        public TechnicianViewResponse technicican { get; set; } = null!;
    }
}
