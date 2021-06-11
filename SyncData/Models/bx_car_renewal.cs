using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncData.Models
{
    public partial class bx_car_renewal
    {
        public long Id { get; set; }
        public string LicenseNo { get; set; }
        private string? _LastYearSource;
        public string? LastYearSource { get { if (string.IsNullOrEmpty(_LastYearSource)) return "-1"; else { return _LastYearSource; } } set { _LastYearSource = value; } }
        private string? _CheSun;
        public string? CheSun { get { if (string.IsNullOrEmpty(_CheSun)) return "0"; else { return _CheSun; } } set { _CheSun = value; } }
        private string? _SanZhe;
        public string? SanZhe { get { if (string.IsNullOrEmpty(_SanZhe)) return "0"; else { return _SanZhe; } } set { _SanZhe = value; } }
        private string? _DaoQiang;
        public string? DaoQiang { get { if (string.IsNullOrEmpty(_DaoQiang)) return "0"; else { return _DaoQiang; } } set { _DaoQiang = value; } }
        private string? _SiJi;
        public string? SiJi { get { if (string.IsNullOrEmpty(_SiJi)) return "0"; else { return _SiJi; } } set { _SiJi = value; } }
        private string? _ChengKe;
        public string? ChengKe { get { if (string.IsNullOrEmpty(_ChengKe)) return "0"; else { return _ChengKe; } } set { _ChengKe = value; } }
        private string? _BoLi;
        public string? BoLi { get { if (string.IsNullOrEmpty(_BoLi)) return "0"; else { return _BoLi; } } set { _BoLi = value; } }
        private string? _HuaHen;
        public string? HuaHen { get { if (string.IsNullOrEmpty(_HuaHen)) return "0"; else { return _HuaHen; } } set { _HuaHen = value; } }
        private string? _BuJiMianCheSun;
        public string? BuJiMianCheSun { get { if (string.IsNullOrEmpty(_BuJiMianCheSun)) return "0"; else { return _BuJiMianCheSun; } } set { _BuJiMianCheSun = value; } }
        private string? _BuJiMianSanZhe;
        public string? BuJiMianSanZhe { get { if (string.IsNullOrEmpty(_BuJiMianSanZhe)) return "0"; else { return _BuJiMianSanZhe; } } set { _BuJiMianSanZhe = value; } }
        private string? _BuJiMianDaoQiang;
        public string? BuJiMianDaoQiang { get { if (string.IsNullOrEmpty(_BuJiMianDaoQiang)) return "0"; else { return _BuJiMianDaoQiang; } } set { _BuJiMianDaoQiang = value; } }
        private string? _BuJiMianRenYuan;
        public string? BuJiMianRenYuan { get { if (string.IsNullOrEmpty(_BuJiMianRenYuan)) return "0"; else { return _BuJiMianRenYuan; } } set { _BuJiMianRenYuan = value; } }
        private string? _BuJiMianSiJi;
        public string? BuJiMianSiJi { get { if (string.IsNullOrEmpty(_BuJiMianSiJi)) return "0"; else { return _BuJiMianSiJi; } } set { _BuJiMianSiJi = value; } }
        private string? _BuJiMianChengKe;
        public string? BuJiMianChengKe { get { if (string.IsNullOrEmpty(_BuJiMianChengKe)) return "0"; else { return _BuJiMianChengKe; } } set { _BuJiMianChengKe = value; } }
        private string? _BuJiMianFuJia;
        public string? BuJiMianFuJia { get { if (string.IsNullOrEmpty(_BuJiMianFuJia)) return "0"; else { return _BuJiMianFuJia; } } set { _BuJiMianFuJia = value; } }
        private string? _BuJiMianZiRan;
        public string? BuJiMianZiRan { get { if (string.IsNullOrEmpty(_BuJiMianZiRan)) return "0"; else { return _BuJiMianZiRan; } } set { _BuJiMianZiRan = value; } }
        private string? _BuJiMianSheShui;
        public string? BuJiMianSheShui { get { if (string.IsNullOrEmpty(_BuJiMianSheShui)) return "0"; else { return _BuJiMianSheShui; } } set { _BuJiMianSheShui = value; } }
        private string? _BuJiMianHuaHen;
        public string? BuJiMianHuaHen { get { if (string.IsNullOrEmpty(_BuJiMianHuaHen)) return "0"; else { return _BuJiMianHuaHen; } } set { _BuJiMianHuaHen = value; } }
        private string? _TeYue;
        public string? TeYue { get { if (string.IsNullOrEmpty(_TeYue)) return "0"; else { return _TeYue; } } set { _TeYue = value; } }
        private string? _SheShui;
        public string? SheShui { get { if (string.IsNullOrEmpty(_SheShui)) return "0"; else { return _SheShui; } } set { _SheShui = value; } }
        private string? _CheDeng;
        public string? CheDeng { get { if (string.IsNullOrEmpty(_CheDeng)) return "0"; else { return _CheDeng; } } set { _CheDeng = value; } }
        private string? _ZiRan;
        public string? ZiRan { get { if (string.IsNullOrEmpty(_ZiRan)) return "0"; else { return _ZiRan; } } set { _ZiRan = value; } }
        private string? _FeiYongBuChang;
        public string? FeiYongBuChang { get { if (string.IsNullOrEmpty(_FeiYongBuChang)) return "0"; else { return _FeiYongBuChang; } } set { _FeiYongBuChang = value; } }
        private string? _FeiYongBuChangDays;
        public string? FeiYongBuChangDays { get { if (string.IsNullOrEmpty(_FeiYongBuChangDays)) return "0"; else { return _FeiYongBuChangDays; } } set { _FeiYongBuChangDays = value; } }
        public string FeiYongBuChangConfig { get; set; }
        private string? _XiuLiChang;
        public string? XiuLiChang { get { if (string.IsNullOrEmpty(_XiuLiChang)) return "0"; else { return _XiuLiChang; } } set { _XiuLiChang = value; } }
        private string? _XiuLiChangType;
        public string? XiuLiChangType { get { if (string.IsNullOrEmpty(_XiuLiChangType)) return "-1"; else { return _XiuLiChangType; } } set { _XiuLiChangType = value; } }
        public string XiuLiChangConfig { get; set; }
        private string? _SheBeiSunShi;
        public string? SheBeiSunShi { get { if (string.IsNullOrEmpty(_SheBeiSunShi)) return "0"; else { return _SheBeiSunShi; } } set { _SheBeiSunShi = value; } }
        public string SheBeiSunShiConfig { get; set; }
        private string? _HuoWuZeRen;
        public string? HuoWuZeRen { get { if (string.IsNullOrEmpty(_HuoWuZeRen)) return "0"; else { return _HuoWuZeRen; } } set { _HuoWuZeRen = value; } }
        private string? _SanFangTeYue;
        public string? SanFangTeYue { get { if (string.IsNullOrEmpty(_SanFangTeYue)) return "0"; else { return _SanFangTeYue; } } set { _SanFangTeYue = value; } }
        private string? _JingShenSunShi;
        public string? JingShenSunShi { get { if (string.IsNullOrEmpty(_JingShenSunShi)) return "0"; else { return _JingShenSunShi; } } set { _JingShenSunShi = value; } }
        private string? _BuJiMianJingShenSunShi;
        public string? BuJiMianJingShenSunShi { get { if (string.IsNullOrEmpty(_BuJiMianJingShenSunShi)) return "0"; else { return _BuJiMianJingShenSunShi; } } set { _BuJiMianJingShenSunShi = value; } }
        private string? _CreateTime;
        public string? CreateTime { get { if (string.IsNullOrEmpty(_CreateTime)) return DateTime.MinValue.ToShortDateString(); else { return _CreateTime; } } set { _CreateTime = value; } }
        private string? _LastForceEndDate;
        public string? LastForceEndDate { get { if (string.IsNullOrEmpty(_LastForceEndDate)) return DateTime.MinValue.ToShortDateString(); else { return _LastForceEndDate; } } set { _LastForceEndDate = value; } }
        private string? _LastBizEndDate;
        public string? LastBizEndDate { get { if (string.IsNullOrEmpty(_LastBizEndDate)) return DateTime.MinValue.ToShortDateString(); else { return _LastBizEndDate; } } set { _LastBizEndDate = value; } }
        private string? _NextForceStartDate;
        public string? NextForceStartDate { get { if (string.IsNullOrEmpty(_NextForceStartDate)) return DateTime.MinValue.ToShortDateString(); else { return _NextForceStartDate; } } set { _NextForceStartDate = value; } }
        private string? _NextBizStartDate;
        public string? NextBizStartDate { get { if (string.IsNullOrEmpty(_NextBizStartDate)) return DateTime.MinValue.ToShortDateString(); else { return _NextBizStartDate; } } set { _NextBizStartDate = value; } }
        public string InsuredName { get; set; }
        public string InsuredIdCard { get; set; }
        private string? _InsuredIdType;
        public string? InsuredIdType { get { if (string.IsNullOrEmpty(_InsuredIdType)) return "0"; else { return _InsuredIdType; } } set { _InsuredIdType = value; } }
        public string InsuredMobile { get; set; }
        public string HolderName { get; set; }
        public string HolderIdCard { get; set; }
        private string? _HolderIdType;
        public string? HolderIdType { get { if (string.IsNullOrEmpty(_HolderIdType)) return "0"; else { return _HolderIdType; } } set { _HolderIdType = value; } }
        public string HolderMobile { get; set; }
        private string? _RateFactor1;
        public string? RateFactor1 { get { if (string.IsNullOrEmpty(_RateFactor1)) return "0"; else { return _RateFactor1; } } set { _RateFactor1 = value; } }
        private string? _RateFactor2;
        public string? RateFactor2 { get { if (string.IsNullOrEmpty(_RateFactor2)) return "0"; else { return _RateFactor2; } } set { _RateFactor2 = value; } }
        private string? _RateFactor3;
        public string? RateFactor3 { get { if (string.IsNullOrEmpty(_RateFactor3)) return "0"; else { return _RateFactor3; } } set { _RateFactor3 = value; } }
        private string? _RateFactor4;
        public string? RateFactor4 { get { if (string.IsNullOrEmpty(_RateFactor4)) return "0"; else { return _RateFactor4; } } set { _RateFactor4 = value; } }
        private string? _RenewalYear;
        public string? RenewalYear { get { if (string.IsNullOrEmpty(_RenewalYear)) return "0"; else { return _RenewalYear; } } set { _RenewalYear = value; } }
        private string? _RenewalType;
        public string? RenewalType { get { if (string.IsNullOrEmpty(_RenewalType)) return "0"; else { return _RenewalType; } } set { _RenewalType = value; } }
        public string ForceNO { get; set; }
        public string BizNO { get; set; }
        private string? _RenewalSource;
        public string? RenewalSource { get { if (string.IsNullOrEmpty(_RenewalSource)) return "0"; else { return _RenewalSource; } } set { _RenewalSource = value; } }
        private string? _co_real_value;
        public string? co_real_value { get { if (string.IsNullOrEmpty(_co_real_value)) return "0"; else { return _co_real_value; } } set { _co_real_value = value; } }
        private string? _BizPriceTotal;
        public string? BizPriceTotal { get { if (string.IsNullOrEmpty(_BizPriceTotal)) return "0"; else { return _BizPriceTotal; } } set { _BizPriceTotal = value; } }
        private string? _ForcePriceTotal;
        public string? ForcePriceTotal { get { if (string.IsNullOrEmpty(_ForcePriceTotal)) return "0"; else { return _ForcePriceTotal; } } set { _ForcePriceTotal = value; } }
        private string? _TaxPriceTotal;
        public string? TaxPriceTotal { get { if (string.IsNullOrEmpty(_TaxPriceTotal)) return "0"; else { return _TaxPriceTotal; } } set { _TaxPriceTotal = value; } }
        private string? _BuJiMianSheBeiSunshi;
        public string? BuJiMianSheBeiSunshi { get { if (string.IsNullOrEmpty(_BuJiMianSheBeiSunshi)) return "0"; else { return _BuJiMianSheBeiSunshi; } } set { _BuJiMianSheBeiSunshi = value; } }
        private string? _RenewalCarType;
        public string? RenewalCarType { get { if (string.IsNullOrEmpty(_RenewalCarType)) return "0"; else { return _RenewalCarType; } } set { _RenewalCarType = value; } }
        public string Organization { get; set; }
        private string? _UpdateTime;
        public string? UpdateTime { get { if (string.IsNullOrEmpty(_UpdateTime)) return DateTime.MinValue.ToShortDateString(); else { return _UpdateTime; } } set { _UpdateTime = value; } }
        private string? _InsuredSex;
        public string? InsuredSex { get { if (string.IsNullOrEmpty(_InsuredSex)) return "0"; else { return _InsuredSex; } } set { _InsuredSex = value; } }
        public string InsuredBirthday { get; set; }
        private string? _HolderSex;
        public string? HolderSex { get { if (string.IsNullOrEmpty(_HolderSex)) return "0"; else { return _HolderSex; } } set { _HolderSex = value; } }
        public string HolderBirthday { get; set; }
        public string VinNo { get; set; }
        public string EngineNo { get; set; }
        public string MoldName { get; set; }
        private string? _RegisterDate;
        public string? RegisterDate { get { if (string.IsNullOrEmpty(_RegisterDate)) return DateTime.MinValue.ToShortDateString(); else { return _RegisterDate; } } set { _RegisterDate = value; } }
        public string OwnerIdNo { get; set; }
        public string LicenseOwner { get; set; }
        private string? _OwnerIdNoType;
        public string? OwnerIdNoType { get { if (string.IsNullOrEmpty(_OwnerIdNoType)) return "0"; else { return _OwnerIdNoType; } } set { _OwnerIdNoType = value; } }
        private string? _LicenseType;
        public string? LicenseType { get { if (string.IsNullOrEmpty(_LicenseType)) return "0"; else { return _LicenseType; } } set { _LicenseType = value; } }
        private string? _CarType;
        public string? CarType { get { if (string.IsNullOrEmpty(_CarType)) return "0"; else { return _CarType; } } set { _CarType = value; } }
        private string? _CarUsedType;
        public string? CarUsedType { get { if (string.IsNullOrEmpty(_CarUsedType)) return "0"; else { return _CarUsedType; } } set { _CarUsedType = value; } }
        private string? _SeatCount;
        public string? SeatCount { get { if (string.IsNullOrEmpty(_SeatCount)) return "0"; else { return _SeatCount; } } set { _SeatCount = value; } }
        private string? _ExhaustScale;
        public string? ExhaustScale { get { if (string.IsNullOrEmpty(_ExhaustScale)) return "0"; else { return _ExhaustScale; } } set { _ExhaustScale = value; } }
        private string? _CarEquQuality;
        public string? CarEquQuality { get { if (string.IsNullOrEmpty(_CarEquQuality)) return "0"; else { return _CarEquQuality; } } set { _CarEquQuality = value; } }
        private string? _CarTonCount;
        public string? CarTonCount { get { if (string.IsNullOrEmpty(_CarTonCount)) return "0"; else { return _CarTonCount; } } set { _CarTonCount = value; } }
        private string? _PurchasePrice;
        public string? PurchasePrice { get { if (string.IsNullOrEmpty(_PurchasePrice)) return "0"; else { return _PurchasePrice; } } set { _PurchasePrice = value; } }
        private string? _FuelType;
        public string? FuelType { get { if (string.IsNullOrEmpty(_FuelType)) return "0"; else { return _FuelType; } } set { _FuelType = value; } }
        private string? _ProofType;
        public string? ProofType { get { if (string.IsNullOrEmpty(_ProofType)) return "0"; else { return _ProofType; } } set { _ProofType = value; } }
        private string? _LicenseColor;
        public string? LicenseColor { get { if (string.IsNullOrEmpty(_LicenseColor)) return "0"; else { return _LicenseColor; } } set { _LicenseColor = value; } }
        private string? _ClauseType;
        public string? ClauseType { get { if (string.IsNullOrEmpty(_ClauseType)) return "0"; else { return _ClauseType; } } set { _ClauseType = value; } }
        private string? _RunRegion;
        public string? RunRegion { get { if (string.IsNullOrEmpty(_RunRegion)) return "0"; else { return _RunRegion; } } set { _RunRegion = value; } }
        private string? _TransferDate;
        public string? TransferDate { get { if (string.IsNullOrEmpty(_TransferDate)) return DateTime.MinValue.ToShortDateString(); else { return _TransferDate; } } set { _TransferDate = value; } }
        public string AutoModelCode { get; set; }
        public string VehicleYear { get; set; }
        public string DriveLicenseCaryTypeValue { get; set; }
        public string DriveLicenseCarTypeName { get; set; }
        private string? _OwnerSex;
        public string? OwnerSex { get { if (string.IsNullOrEmpty(_OwnerSex)) return "0"; else { return _OwnerSex; } } set { _OwnerSex = value; } }
        public string OwnerBirthday { get; set; }
        private string? _AnalogyPrice;
        public string? AnalogyPrice { get { if (string.IsNullOrEmpty(_AnalogyPrice)) return "0"; else { return _AnalogyPrice; } } set { _AnalogyPrice = value; } }
        private string? _SanZheJieJiaRi;
        public string? SanZheJieJiaRi { get { if (string.IsNullOrEmpty(_SanZheJieJiaRi)) return "0"; else { return _SanZheJieJiaRi; } } set { _SanZheJieJiaRi = value; } }
        public string PAAutoModelCode { get; set; }
        private string? _IsQuoteRepeat;
        public string? IsQuoteRepeat { get { if (string.IsNullOrEmpty(_IsQuoteRepeat)) return "0"; else { return _IsQuoteRepeat; } } set { _IsQuoteRepeat = value; } }
        public string OrganizationCode { get; set; }
        private string? _PricingRate;
        public string? PricingRate { get { if (string.IsNullOrEmpty(_PricingRate)) return "0"; else { return _PricingRate; } } set { _PricingRate = value; } }
        //public double YongYaoSanZhe { get; set; }
        //public double YongYaoSiJi { get; set; }
        //public double YongYaoChengKe { get; set; }
        //public double ZengZhiJiuYuan { get; set; }
        //public string ZengZhiAnJian { get; set; }
        //public double ZengZhiDaiJia { get; set; }
        //public double ZengZhiSongJian { get; set; }
        //public double CheLunSunShi { get; set; }
        //public double FaDongJiSunHuaiChuWai { get; set; }
        //public double MianPeiCheSun { get; set; }
        //public double MianPeiSanZhe { get; set; }
        //public double MianPeiSiJi { get; set; }
        //public double MianPeiChengKe { get; set; }
        //public double JingShenSanZhe { get; set; }
        //public double JingShenSiJi { get; set; }
        //public double JingShenChengKe { get; set; }
    }
}
