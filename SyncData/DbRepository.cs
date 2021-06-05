using Dapper;
using log4net;
using log4net.Config;
using log4net.Repository;
using SyncData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SyncData
{
    public class DbRepository
    {
        public int InsertAgent(ILog log, List<bx_agent> list)
        {
            StringBuilder sql = new StringBuilder();
            if (list != null && list.Any())
            {
                sql.Append("insert into bx_agent (Id,AgentName,Mobile,OpenId,ShareCode,CreateTime,IsBigAgent,FlagId,ParentAgent,ParentRate,AgentRate,ReviewRate,PayType,AgentGetPay,CommissionType,ParentShareCode,IsUsed,AgentAccount,AgentPassWord,IsGenJin,IsDaiLi,IsShow,IsShowCalc,SecretKey,IsLiPei,AgentType,MessagePayType,Region,BatchRenewalTotalCount,ManagerRoleId,BatchRenewalFrequency,AgentAddress,RegType,IsQuote,IsSubmit,TopAgentId,ClientName,PurchasedCommodity,agent_level,commodity,platform,repeat_quote,EffectiveCallDuration,endDate,accountType,openQuote,loginType,robotCount,agentBrand,contractEndDate,quoteCompany,phone_is_wechat,hide_phone,group_id,picc_account,zhen_bang_type,charge_person,zs_type,bxShop) values ");
                foreach (var item in list)
                {
                    sql.Append($" ('{item.Id}','{item.AgentName}','{item.Mobile}','{item.OpenId}','{item.ShareCode}','{item.CreateTime}','{item.IsBigAgent}','{item.FlagId}','{item.ParentAgent}','{item.ParentRate}','{item.AgentRate}','{item.ReviewRate}','{item.PayType}','{item.AgentGetPay}','{item.CommissionType}','{item.ParentShareCode}','{item.IsUsed}','{item.AgentAccount}','{item.AgentPassWord}','{item.IsGenJin}','{item.IsDaiLi}','{item.IsShow}','{item.IsShowCalc}','{item.SecretKey}','{item.IsLiPei}','{item.AgentType}','{item.MessagePayType}','{item.Region}','{item.BatchRenewalTotalCount}','{item.ManagerRoleId}','{item.BatchRenewalFrequency}','{item.AgentAddress}','{item.RegType}','{item.IsQuote}','{item.IsSubmit}','{item.TopAgentId}','{item.ClientName}','{item.PurchasedCommodity}','{item.agent_level}','{item.commodity}','{item.platform}','{item.repeat_quote}','{item.EffectiveCallDuration}','{item.endDate}','{item.accountType}','{item.openQuote}','{item.loginType}','{item.robotCount}','{item.agentBrand}','{item.contractEndDate}','{item.quoteCompany}','{item.phone_is_wechat}','{item.hide_phone}','{item.group_id}','{item.picc_account}','{item.zhen_bang_type}','{item.charge_person}','{item.zs_type}','{item.bxShop}'),");
                }
            }
            if (sql.Length == 0)
            {
                return 0;
            }
            try
            {
                using (var conn = DataFactory.DbService())
                {
                    return conn.Execute(sql.Remove(sql.Length-1,1).ToString());
                }
            }
            catch (Exception ex)
            {
                log.Info("发生异常:" + ex.Source + "\n" + ex.StackTrace + "\n" + ex.Message + "\n" + ex.InnerException);
            }
            return 0;
        }
        public int InsertCarinfo(ILog log, List<bx_carinfo> list)
        {
            StringBuilder sql = new StringBuilder();
            if (list != null && list.Any())
            {
                sql.Append("INSERT INTO bx_carinfo (id, license_no, engine_no, vin_no, mold_name, register_date, owner_idno, license_owner, owner_idno_type, license_type, car_type, car_used_type, seat_count, exhaust_scale, car_equ_quality, car_ton_count, purchase_price, fuel_type, proof_type, license_color, clause_type, run_region, create_time, update_time, transfer_date, auto_model_code, VehicleYear, drivelicense_caryype_value, drivelicense_cartype_name, RenewalCarType, OwnerSex, OwnerBirthday, analogy_price, pa_auto_model_code, BrandName, VehiclesName) VALUES ");
                foreach (var item in list)
                {
                    sql.Append($" ('{item.id}','{item.license_no}','{item.engine_no}','{item.vin_no}','{item.mold_name}','{item.register_date}','{item.owner_idno}','{item.license_owner}','{item.owner_idno_type}','{item.license_type}','{item.car_type}','{item.car_used_type}','{item.seat_count}','{item.exhaust_scale}','{item.car_equ_quality}','{item.car_ton_count}','{item.purchase_price}','{item.fuel_type}','{item.proof_type}','{item.license_color}','{item.clause_type}','{item.run_region}','{item.create_time}','{item.update_time}','{item.transfer_date}','{item.auto_model_code}','{item.VehicleYear}','{item.drivelicense_caryype_value}','{item.drivelicense_cartype_name}','{item.RenewalCarType}','{item.OwnerSex}','{item.OwnerBirthday}','{item.analogy_price}','{item.pa_auto_model_code}','{item.BrandName}','{item.VehiclesName}'),");
                }
            }
            if (sql.Length == 0)
            {
                return 0;
            }
            try
            {
                using (var conn = DataFactory.DbService())
                {
                    return conn.Execute(sql.Remove(sql.Length-1,1).ToString());
                }
            }
            catch (Exception ex)
            {
                log.Info("发生异常:" + ex.Source + "\n" + ex.StackTrace + "\n" + ex.Message + "\n" + ex.InnerException);
            }
            return 0;
        }
        public int InsertCarrenewal(ILog log, List<bx_car_renewal> list)
        {
            StringBuilder sql = new StringBuilder();
            if (list != null && list.Any())
            {
                sql.Append("INSERT INTO bx_car_renewal (Id, LicenseNo, LastYearSource, CheSun, SanZhe, DaoQiang, SiJi, ChengKe, BoLi, HuaHen, BuJiMianCheSun, BuJiMianSanZhe, BuJiMianDaoQiang, BuJiMianRenYuan, BuJiMianSiJi, BuJiMianChengKe, BuJiMianFuJia, BuJiMianZiRan, BuJiMianSheShui, BuJiMianHuaHen, TeYue, SheShui, CheDeng, ZiRan, FeiYongBuChang, FeiYongBuChangDays, FeiYongBuChangConfig, XiuLiChang, XiuLiChangType, XiuLiChangConfig, SheBeiSunShi, SheBeiSunShiConfig, HuoWuZeRen, SanFangTeYue, JingShenSunShi, BuJiMianJingShenSunShi, CreateTime, LastForceEndDate, LastBizEndDate, NextForceStartDate, NextBizStartDate, InsuredName, InsuredIdCard, InsuredIdType, InsuredMobile, HolderName, HolderIdCard, HolderIdType, HolderMobile, RateFactor1, RateFactor2, RateFactor3, RateFactor4, RenewalYear, RenewalType, ForceNO, BizNO, RenewalSource, co_real_value, BizPriceTotal, ForcePriceTotal, TaxPriceTotal, BuJiMianSheBeiSunshi, RenewalCarType, Organization, UpdateTime, InsuredSex, InsuredBirthday, HolderSex, HolderBirthday, VinNo, EngineNo, MoldName, RegisterDate, OwnerIdNo, LicenseOwner, OwnerIdNoType, LicenseType, CarType, CarUsedType, SeatCount, ExhaustScale, CarEquQuality, CarTonCount, PurchasePrice, FuelType, ProofType, LicenseColor, ClauseType, RunRegion, TransferDate, AutoModelCode, VehicleYear, DriveLicenseCaryTypeValue, DriveLicenseCarTypeName, OwnerSex, OwnerBirthday, AnalogyPrice, SanZheJieJiaRi, PAAutoModelCode, IsQuoteRepeat, OrganizationCode) VALUES  ");
                foreach (var item in list)
                {
                    sql.Append($"('{item.Id}','{item.LicenseNo}','{item.LastYearSource}','{item.CheSun}','{item.SanZhe}','{item.DaoQiang}','{item.SiJi}','{item.ChengKe}','{item.BoLi}','{item.HuaHen}','{item.BuJiMianCheSun}','{item.BuJiMianSanZhe}','{item.BuJiMianDaoQiang}','{item.BuJiMianRenYuan}','{item.BuJiMianSiJi}','{item.BuJiMianChengKe}','{item.BuJiMianFuJia}','{item.BuJiMianZiRan}','{item.BuJiMianSheShui}','{item.BuJiMianHuaHen}','{item.TeYue}','{item.SheShui}','{item.CheDeng}','{item.ZiRan}','{item.FeiYongBuChang}','{item.FeiYongBuChangDays}','{item.FeiYongBuChangConfig}','{item.XiuLiChang}','{item.XiuLiChangType}','{item.XiuLiChangConfig}','{item.SheBeiSunShi}','{item.SheBeiSunShiConfig}','{item.HuoWuZeRen}','{item.SanFangTeYue}','{item.JingShenSunShi}','{item.BuJiMianJingShenSunShi}','{item.CreateTime}','{item.LastForceEndDate}','{item.LastBizEndDate}','{item.NextForceStartDate}','{item.NextBizStartDate}','{item.InsuredName}','{item.InsuredIdCard}','{item.InsuredIdType}','{item.InsuredMobile}','{item.HolderName}','{item.HolderIdCard}','{item.HolderIdType}','{item.HolderMobile}','{item.RateFactor1}','{item.RateFactor2}','{item.RateFactor3}','{item.RateFactor4}','{item.RenewalYear}','{item.RenewalType}','{item.ForceNO}','{item.BizNO}','{item.RenewalSource}','{item.co_real_value}','{item.BizPriceTotal}','{item.ForcePriceTotal}','{item.TaxPriceTotal}','{item.BuJiMianSheBeiSunshi}','{item.RenewalCarType}','{item.Organization}','{item.UpdateTime}','{item.InsuredSex}','{item.InsuredBirthday}','{item.HolderSex}','{item.HolderBirthday}','{item.VinNo}','{item.EngineNo}','{item.MoldName}','{item.RegisterDate}','{item.OwnerIdNo}','{item.LicenseOwner}','{item.OwnerIdNoType}','{item.LicenseType}','{item.CarType}','{item.CarUsedType}','{item.SeatCount}','{item.ExhaustScale}','{item.CarEquQuality}','{item.CarTonCount}','{item.PurchasePrice}','{item.FuelType}','{item.ProofType}','{item.LicenseColor}','{item.ClauseType}','{item.RunRegion}','{item.TransferDate}','{item.AutoModelCode}','{item.VehicleYear}','{item.DriveLicenseCaryTypeValue}','{item.DriveLicenseCarTypeName}','{item.OwnerSex}','{item.OwnerBirthday}','{item.AnalogyPrice}','{item.SanZheJieJiaRi}','{item.PAAutoModelCode}','{item.IsQuoteRepeat}','{item.OrganizationCode}'),");
                }
            }
            if (sql.Length == 0)
            {
                return 0;
            }
            try
            {
                using (var conn = DataFactory.DbService())
                {
                    return conn.Execute(sql.Remove(sql.Length - 1, 1).ToString());
                }
            }
            catch (Exception ex)
            {
                log.Info("发生异常:" + ex.Source + "\n" + ex.StackTrace + "\n" + ex.Message + "\n" + ex.InnerException);
            }
            return 0;
        }
    }
}
