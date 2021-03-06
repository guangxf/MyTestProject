﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWeb.Models
{
    public partial class bx_car_renewal
    {
        public long Id { get; set; }
        public string LicenseNo { get; set; }
        public Nullable<int> LastYearSource { get; set; }
        public Nullable<double> CheSun { get; set; }
        public Nullable<double> SanZhe { get; set; }
        public Nullable<double> DaoQiang { get; set; }
        public Nullable<double> SiJi { get; set; }
        public Nullable<double> ChengKe { get; set; }
        public Nullable<double> BoLi { get; set; }
        public Nullable<double> HuaHen { get; set; }
        public Nullable<double> BuJiMianCheSun { get; set; }
        public Nullable<double> BuJiMianSanZhe { get; set; }
        public Nullable<double> BuJiMianDaoQiang { get; set; }
        public Nullable<double> BuJiMianRenYuan { get; set; }
        public Nullable<double> BuJiMianSiJi { get; set; }
        public Nullable<double> BuJiMianChengKe { get; set; }
        public Nullable<double> BuJiMianFuJia { get; set; }
        public Nullable<double> BuJiMianZiRan { get; set; }
        public Nullable<double> BuJiMianSheShui { get; set; }
        public Nullable<double> BuJiMianHuaHen { get; set; }
        public Nullable<double> TeYue { get; set; }
        public Nullable<double> SheShui { get; set; }
        public Nullable<double> CheDeng { get; set; }
        public Nullable<double> ZiRan { get; set; }
        public Nullable<double> FeiYongBuChang { get; set; }
        public Nullable<int> FeiYongBuChangDays { get; set; }
        public string FeiYongBuChangConfig { get; set; }
        public Nullable<double> XiuLiChang { get; set; }
        public Nullable<int> XiuLiChangType { get; set; }
        public string XiuLiChangConfig { get; set; }
        public Nullable<double> SheBeiSunShi { get; set; }
        public string SheBeiSunShiConfig { get; set; }
        public Nullable<double> HuoWuZeRen { get; set; }
        public Nullable<double> SanFangTeYue { get; set; }
        public Nullable<double> JingShenSunShi { get; set; }
        public Nullable<double> BuJiMianJingShenSunShi { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> LastForceEndDate { get; set; }
        public Nullable<System.DateTime> LastBizEndDate { get; set; }
        public Nullable<System.DateTime> NextForceStartDate { get; set; }
        public Nullable<System.DateTime> NextBizStartDate { get; set; }
        public string InsuredName { get; set; }
        public string InsuredIdCard { get; set; }
        public Nullable<int> InsuredIdType { get; set; }
        public string InsuredMobile { get; set; }
        public string HolderName { get; set; }
        public string HolderIdCard { get; set; }
        public Nullable<int> HolderIdType { get; set; }
        public string HolderMobile { get; set; }
        public Nullable<decimal> RateFactor1 { get; set; }
        public Nullable<decimal> RateFactor2 { get; set; }
        public Nullable<decimal> RateFactor3 { get; set; }
        public Nullable<decimal> RateFactor4 { get; set; }
        public Nullable<int> RenewalYear { get; set; }
        public Nullable<int> RenewalType { get; set; }
        public string ForceNO { get; set; }
        public string BizNO { get; set; }
        public Nullable<int> RenewalSource { get; set; }
        public Nullable<decimal> co_real_value { get; set; }
        public Nullable<double> BizPriceTotal { get; set; }
        public Nullable<double> ForcePriceTotal { get; set; }
        public Nullable<double> TaxPriceTotal { get; set; }
        public Nullable<double> BuJiMianSheBeiSunshi { get; set; }
        public Nullable<int> RenewalCarType { get; set; }
        public string Organization { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<int> InsuredSex { get; set; }
        public string InsuredBirthday { get; set; }
        public Nullable<int> HolderSex { get; set; }
        public string HolderBirthday { get; set; }
        public string VinNo { get; set; }
        public string EngineNo { get; set; }
        public string MoldName { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
        public string OwnerIdNo { get; set; }
        public string LicenseOwner { get; set; }
        public Nullable<int> OwnerIdNoType { get; set; }
        public Nullable<int> LicenseType { get; set; }
        public Nullable<int> CarType { get; set; }
        public Nullable<int> CarUsedType { get; set; }
        public Nullable<int> SeatCount { get; set; }
        public Nullable<decimal> ExhaustScale { get; set; }
        public Nullable<decimal> CarEquQuality { get; set; }
        public Nullable<decimal> CarTonCount { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<int> FuelType { get; set; }
        public Nullable<int> ProofType { get; set; }
        public Nullable<int> LicenseColor { get; set; }
        public Nullable<int> ClauseType { get; set; }
        public Nullable<int> RunRegion { get; set; }
        public Nullable<System.DateTime> TransferDate { get; set; }
        public string AutoModelCode { get; set; }
        public string VehicleYear { get; set; }
        public string DriveLicenseCaryTypeValue { get; set; }
        public string DriveLicenseCarTypeName { get; set; }
        public Nullable<int> OwnerSex { get; set; }
        public string OwnerBirthday { get; set; }
        public Nullable<decimal> AnalogyPrice { get; set; }
        public Nullable<double> SanZheJieJiaRi { get; set; }
        public string PAAutoModelCode { get; set; }
        public Nullable<int> IsQuoteRepeat { get; set; }
        public string OrganizationCode { get; set; }
    }
}
