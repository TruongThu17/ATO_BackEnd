﻿using Data.Models;
using Microsoft.EntityFrameworkCore;
using Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.TourismPackageSer
{
    public class TourismPackageService : ITourismPackageService
    {
        private readonly IRepository<TourismPackage> _tourismPackageRepository;
        private readonly IRepository<TouristFacility> _touristFacilityRepository;
        private readonly IRepository<Activity> _activityRepository;
        private readonly IRepository<Product> _productRepository;
        public TourismPackageService(
            IRepository<TourismPackage> tourismPackageRepository, 
            IRepository<TouristFacility> touristFacilityRepository,
            IRepository<Activity> activityRepository,
            IRepository<Product> productRepository)
        {
            _tourismPackageRepository = tourismPackageRepository;
            _touristFacilityRepository = touristFacilityRepository;
            _activityRepository = activityRepository;
            _productRepository = productRepository;
        }

        public async Task<bool> CreateActivity_AFTO(Activity responseResult)
        {
            try
            {
                responseResult.ActivityId = Guid.NewGuid();
                responseResult.CreateDate = DateTime.UtcNow;
                responseResult.StatusApproval = StatusApproval.Processing;
                if (responseResult.Products != null && responseResult.Products.Any())
                {
                    var ProductIds = responseResult.Products.Select(tg => tg.ProductId).ToList();

                    var Products = await _productRepository.Query()
                        .Where(tg => ProductIds.Contains(tg.ProductId))
                        .ToListAsync();

                    responseResult.Products = Products;
                }
                await _activityRepository.AddRangeAsync(responseResult);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> CreateTourismPackage_AFTO(TourismPackage responseResult, Guid UserId)
        {
            try
            {
                TouristFacility TouristFacility = await _touristFacilityRepository.Query()
                    .SingleOrDefaultAsync(x => x.UserId == UserId);
                responseResult.PackageId = Guid.NewGuid();
                responseResult.TouristFacilityId = TouristFacility.TouristFacilityId;
                responseResult.CreateDate = DateTime.UtcNow;
                responseResult.StatusApproval = StatusApproval.Processing;
                await _tourismPackageRepository.AddAsync(responseResult);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<Activity> GetActivity(Guid ActivityId)
        {
            try
            {
                return await _activityRepository.Query()
                    .Include(b => b.Products)
                    .SingleOrDefaultAsync(x => x.ActivityId == ActivityId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<List<TourismPackage>> GetListTourismPackages(Guid UserId)
        {
            try
            {
          
                return await _tourismPackageRepository.Query()
                    .Include(x => x.TourDestinations)
                    .Include(x => x.Activities)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<List<TourismPackage>> GetListTourism_TC()
        {
            try
            {
                return await _tourismPackageRepository.Query()
                    .Where(x => x.StatusOperating == StatusOperating.Active)
                    .ToListAsync();
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<TourismPackage> GetTourismPackage(Guid PackageId)
        {
            try
            {
                return await _tourismPackageRepository.Query()
                    .Include(b => b.Activities)
                    .ThenInclude(b => b.Products)
                    .SingleOrDefaultAsync(x => x.PackageId == PackageId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
        public async Task<TourismPackage> GetTourismPackage_TC(Guid PackageId)
        {
            try
            {
                return await _tourismPackageRepository.Query()
                    .Include(b => b.Activities.Where(x=>x.StatusApproval== StatusApproval.Approved))
                    .ThenInclude(b => b.Products)
                    .SingleOrDefaultAsync(x => x.PackageId == PackageId);
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateActivity_AFTO(Guid activityId, Activity responseResult)
        {
            try
            {
                Activity existingActivity = await _activityRepository.Query()
                    .SingleOrDefaultAsync(x => x.ActivityId == activityId);

                if (existingActivity == null)
                {
                    throw new Exception("Không tìm thấy hoạt động trải nghiệm!");
                }

                existingActivity.ActivityName = responseResult.ActivityName;
                existingActivity.Description = responseResult.Description;
                existingActivity.DurationInHours = responseResult.DurationInHours;
                existingActivity.DurationInHoursType = responseResult.DurationInHoursType;
                existingActivity.Location = responseResult.Location;
                existingActivity.Imgs = responseResult.Imgs;
                existingActivity.BreakTimeInMinutesType = responseResult.BreakTimeInMinutesType;
                existingActivity.PackageId = responseResult.PackageId;
                existingActivity.UpdateDate = DateTime.UtcNow;
                existingActivity.Products?.Clear();
                if (existingActivity.Products == null)
                {
                    var ProductIds = responseResult.Products.Select(tg => tg.ProductId).ToList();
                    var Products = await _productRepository.Query()
                        .Where(tg => ProductIds.Contains(tg.ProductId))
                        .ToListAsync();
                    foreach (var tg in Products)
                    { 
                        existingActivity.Products.Add(tg);
                    }
                }
                await _activityRepository.UpdateRangeAsync(existingActivity);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }

        public async Task<bool> UpdateTourismPackage_AFTO(Guid packageId, TourismPackage responseResult)
        {
            try
            {
                TourismPackage existingTourismPackage = await _tourismPackageRepository.Query()
                    .SingleOrDefaultAsync(x => x.PackageId == packageId);

                if (existingTourismPackage == null)
                {
                    throw new Exception("Không tìm thấy gói du lịch!");
                }

                existingTourismPackage.PackageName = responseResult.PackageName;
                existingTourismPackage.Description = responseResult.Description;
                existingTourismPackage.Price = responseResult.Price;
                existingTourismPackage.Durations = responseResult.Durations;
                existingTourismPackage.DurationsType = responseResult.DurationsType;
                existingTourismPackage.StatusOperating = responseResult.StatusOperating;
                existingTourismPackage.UpdateDate = DateTime.UtcNow;

                await _tourismPackageRepository.UpdateAsync(existingTourismPackage);

                return true;
            }
            catch (Exception)
            {
                throw new Exception("Đã xảy ra lỗi vui lòng thử lại sau!");
            }
        }
    }
}
