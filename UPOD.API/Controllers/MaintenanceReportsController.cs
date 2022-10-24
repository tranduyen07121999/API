﻿using Microsoft.AspNetCore.Mvc;
using UPOD.REPOSITORIES.RequestModels;
using UPOD.REPOSITORIES.ResponseModels;
using UPOD.SERVICES.Services;

namespace UPOD.API.Controllers
{
    [ApiController]
    [Route("api/maintenance_reports")]
    public partial class MaintenanceReportsController : ControllerBase
    {

        private readonly IMaintenanceReportService _maintenance_report_sv;
        public MaintenanceReportsController(IMaintenanceReportService maintenance_report_sv)
        {
            _maintenance_report_sv = maintenance_report_sv;
        }

        [HttpGet]
        [Route("get_list_maintenance_reports")]
        public async Task<ActionResult<ResponseModel<MaintenanceReportResponse>>> GetListMaintenanceReports([FromQuery] PaginationRequest model, [FromQuery] FilterRequest value)
        {
            try
            {
                return await _maintenance_report_sv.GetListMaintenanceReports(model, value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("get_details_maintenance_report")]
        public async Task<ActionResult<ObjectModelResponse>> GetDetailsMaintenanceReport(Guid id)
        {
            try
            {
                return await _maintenance_report_sv.GetDetailsMaintenanceReport(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("create_maintenance_report")]
        public async Task<ActionResult<ObjectModelResponse>> CreateMaintenanceReport(MaintenanceReportRequest model)
        {
            try
            {
                return await _maintenance_report_sv.CreateMaintenanceReport(model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("create_maintenance_report_service")]
        public async Task<ActionResult<ResponseModel<MaintenanceReportServiceResponse>>> CreateMaintenanceReportService(Guid id, ListMaintenanceReportServiceRequest model)
        {
            try
            {
                return await _maintenance_report_sv.CreateMaintenanceReportService(id, model);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //[HttpPut]
        //[Route("update_guideline_by_id")]
        //public async Task<ActionResult<ObjectModelResponse>> UpdateDervice(Guid id, GuidelineRequest model)
        //{
        //    try
        //    {
        //        return await _guideline_sv.UpdateGuideline(id, model);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        //[HttpPut]
        //[Route("disable_guideline_by_id")]
        //public async Task<ActionResult<ObjectModelResponse>> DisableDervice(Guid id)
        //{
        //    try
        //    {
        //        return await _guideline_sv.DisableGuideline(id);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

    }

}
