﻿using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO.Respone
{
    public class TouristFacilityDTO
    {
        public Guid TouristFacilityId { get; set; }
        public Guid UserId { get; set; }
        public string TouristFacilityName { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public string? ContactInfor { get; set; }
        public string? EmailTouristFacility { get; set; }
        public string? Website { get; set; }
        public string? LogoURL { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateTime { get; set; }
        public virtual TouristFacilityDTO_UserRespone? Account { get; set; }
    }
    public class TouristFacilityDTO_UserRespone
    {
        public Guid Id { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Fullname { get; set; }
        public bool? Gender { get; set; }
        public string? AvatarURL { get; set; }
        public DateTime? Dob { get; set; }
        public bool isAccountActive { get; set; }
    }
}
