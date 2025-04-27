using Data.Models;
using Data.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.FacilityCertificationSer;

public class FacilityCertificationService(IRepository<FacilityCertification> certificationRepo) : IFacilityCertificationService
{
    private readonly IRepository<FacilityCertification> _certificationRepo = certificationRepo;

    public async Task<FacilityCertification> GetByIdAsync(Guid id)
    {
        return await _certificationRepo.GetByIdAsync(id);
    }

    public async Task<List<FacilityCertification>> GetAllByFacilityAsync(Guid facilityId)
    {
        return await _certificationRepo.Query()
            .Where(c => c.TouristFacilityId == facilityId)
            .ToListAsync();
    }

    public async Task<bool> CreateAsync(FacilityCertification certification)
    {
        certification.CertificationId = Guid.NewGuid();
        certification.CreateDate = DateTime.UtcNow;
        await _certificationRepo.AddAsync(certification);
        return true;
    }

    public async Task<bool> UpdateAsync(Guid id, FacilityCertification certification)
    {
        var existing = await _certificationRepo.GetByIdAsync(id);
        if (existing == null) return false;

        existing.CertificationName = certification.CertificationName;
        existing.Imgs = certification.Imgs;
        existing.IssueDate = certification.IssueDate;
        existing.ExpiryDate = certification.ExpiryDate;
        existing.CertificationDetails = certification.CertificationDetails;
        existing.UpdateDate = DateTime.UtcNow;

        await _certificationRepo.UpdateAsync(existing);
        return true;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var certification = await _certificationRepo.GetByIdAsync(id);
        if (certification == null) return false;

        await _certificationRepo.DeleteAsync(certification);
        return true;
    }

    public async Task<bool> ApproveCertificationAsync(Guid id, string reply)
    {
        var certification = await _certificationRepo.GetByIdAsync(id);
        if (certification == null) return false;

        certification.StatusApproval = StatusApproval.Approved;
        certification.ReplyRequest = reply;
        certification.UpdateDate = DateTime.UtcNow;

        await _certificationRepo.UpdateAsync(certification);
        return true;
    }

    public async Task<bool> RejectCertificationAsync(Guid id, string reply)
    {
        var certification = await _certificationRepo.GetByIdAsync(id);
        if (certification == null) return false;

        certification.StatusApproval = StatusApproval.Rejected;
        certification.ReplyRequest = reply;
        certification.UpdateDate = DateTime.UtcNow;

        await _certificationRepo.UpdateAsync(certification);
        return true;
    }
}