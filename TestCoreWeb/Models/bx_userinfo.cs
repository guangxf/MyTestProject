﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWeb.Models
{
    public partial class bx_userinfo
    {
        public long Id { get; set; }
        public Nullable<int> UserId { get; set; }
        public string UserName { get; set; }
        public string LicenseNo { get; set; }
        public string Mobile { get; set; }
        public string OpenId { get; set; }
        public string CityCode { get; set; }
        public string RenewalIdNo { get; set; }
        public string EngineNo { get; set; }
        public string CarVIN { get; set; }
        public Nullable<int> Source { get; set; }
        public Nullable<int> LastYearSource { get; set; }
        public string MoldName { get; set; }
        public string RegisterDate { get; set; }
        public string ApproxDate { get; set; }
        public string Address { get; set; }
        public string VehicleId { get; set; }
        public string StandardName { get; set; }
        public Nullable<int> NeedEngineNo { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> ProcessStep { get; set; }
        public Nullable<int> QuoteStatus { get; set; }
        public Nullable<int> OrderStatus { get; set; }
        public Nullable<int> IsOrder { get; set; }
        public Nullable<int> IsReView { get; set; }
        public Nullable<int> JiSuanType { get; set; }
        public Nullable<int> IsService { get; set; }
        public Nullable<System.DateTime> ServiceTime { get; set; }
        public string Agent { get; set; }
        public string IdCard { get; set; }
        public Nullable<int> IsLastYear { get; set; }
        public string LicenseOwner { get; set; }
        public Nullable<int> IsTest { get; set; }
        public string InsuredName { get; set; }
        public string InsuredMobile { get; set; }
        public string InsuredIdCard { get; set; }
        public string InsuredAddress { get; set; }
        public Nullable<int> IsInputBxData { get; set; }
        public Nullable<int> IsRiskVehicle { get; set; }
        public Nullable<int> IsPeopleQuote { get; set; }
        public Nullable<int> HongBaoId { get; set; }
        public Nullable<decimal> HongBaoAmount { get; set; }
        public Nullable<int> Datasource { get; set; }
        public string ApproxPeopleName { get; set; }
        public Nullable<int> ApproxPeopleId { get; set; }
        public Nullable<System.DateTime> ApproxCreateDate { get; set; }
        public Nullable<int> IsInstalment { get; set; }
        public Nullable<int> IsClosing { get; set; }
        public Nullable<int> IsSingleSubmit { get; set; }
        public Nullable<int> RenewalType { get; set; }
        public Nullable<int> RenewalStatus { get; set; }
        public Nullable<int> InsuredIdType { get; set; }
        public int IsDistributed { get; set; }
        public int OwnerIdCardType { get; set; }
        public string Email { get; set; }
        public string InsuredCertiStartdate { get; set; }
        public string InsuredCertiEnddate { get; set; }
        public string InsuredEmail { get; set; }
        public string HolderIdCard { get; set; }
        public string HolderName { get; set; }
        public string HolderMobile { get; set; }
        public string HolderAddress { get; set; }
        public Nullable<int> HolderIdType { get; set; }
        public string HolderCertiStartdate { get; set; }
        public string HolderCertiEnddate { get; set; }
        public string HolderEmail { get; set; }
        public int CarMoldId { get; set; }
        public int CategoryInfoId { get; set; }
        public string OwnerCertiStartdate { get; set; }
        public string OwnerCertiEnddate { get; set; }
        public string OwnerCertiAddress { get; set; }
        public Nullable<int> RenewalCarType { get; set; }
        public bool IsCamera { get; set; }
        public System.DateTime CameraTime { get; set; }
        public System.DateTime DistributedTime { get; set; }
        public Nullable<int> InsuredSex { get; set; }
        public string InsuredNation { get; set; }
        public string InsuredBirthday { get; set; }
        public string InsuredIssuer { get; set; }
        public Nullable<int> HolderSex { get; set; }
        public string HolderNation { get; set; }
        public string HolderBirthday { get; set; }
        public string HolderIssuer { get; set; }
        public Nullable<int> OwnerSex { get; set; }
        public string OwnerNation { get; set; }
        public string OwnerBirthday { get; set; }
        public string OwnerIssuer { get; set; }
        public int IsChangeRelation { get; set; }
        public Nullable<System.DateTime> LatestRenewalTime { get; set; }
        public Nullable<System.DateTime> LatestQuoteTime { get; set; }
        public int agent_id { get; set; }
        public int CustomerStatus { get; set; }
        public int top_agent_id { get; set; }
        public int IsBatchRenewalData { get; set; }
        public string SixDigitsAfterIdCard { get; set; }
        public Nullable<int> IsSingleLicenseno { get; set; }
        public int zs_zuoxi_id { get; set; }
        public int IsBatchQuote { get; set; }
        public Nullable<System.DateTime> LastForceEndDate { get; set; }
        public Nullable<System.DateTime> LastBizEndDate { get; set; }
        public Nullable<int> LastForceEndMonth { get; set; }
        public Nullable<int> LastBizEndMonth { get; set; }
        public Nullable<int> InputAndRenewalFlag { get; set; }
        public Nullable<long> NewBuid { get; set; }
        public string Guid { get; set; }
    }
}
