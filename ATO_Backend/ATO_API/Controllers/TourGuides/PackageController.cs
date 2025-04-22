﻿using AutoMapper;
using Data.DTO.Respone;
using Data.DTO.Response;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.TourGuidePackageSer;

namespace ATO_API.Controllers.TourGuides;

[Route("api/tour-guide/tour")]
[ApiController]
[Authorize(Roles = "TourGuides")]
public class PackageController : ControllerBase
{
    private readonly ITourGuidePackageService _tourGuidePackageService;
    private readonly IMapper _mapper;

    public PackageController(
        ITourGuidePackageService tourGuidePackageService,
        IMapper mapper)
    {
        _tourGuidePackageService = tourGuidePackageService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetAssignedPackages()
    {
        try
        {
            var guideId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var packages = await _tourGuidePackageService.GetAssignedPackages(Guid.Parse(guideId));
            var response = _mapper.Map<List<TourGuidePackageResponse>>(packages);

            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }

    [HttpGet("{packageId}")]
    public async Task<IActionResult> GetPackageDetails(Guid packageId)
    {
        try
        {
            var guideId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier)?.Value;
            var package = await _tourGuidePackageService.GetPackageDetails(packageId, Guid.Parse(guideId));

            if (package == null)
                return NotFound(new ResponseModel(false, "Package not found or not assigned to you"));

            var response = _mapper.Map<TourGuidePackageResponse>(package);
            return Ok(response);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new ResponseVM
            {
                Status = false,
                Message = ex.Message
            });
        }
    }
}
