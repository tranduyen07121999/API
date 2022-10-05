﻿using System;
using System.Collections.Generic;

namespace UPOD.REPOSITORIES.Models
{
    public partial class MaintenanceReportService
    {
        public Guid Id { get; set; }
        public Guid? MaintenanceReportId { get; set; }
        public Guid? ServiceId { get; set; }

        public virtual MaintenanceReport? MaintenanceReport { get; set; }
        public virtual Service? Service { get; set; }
    }
}
