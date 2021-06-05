using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCoreWeb.Models;

namespace TestCoreWeb.Services
{
    public class DbRepository
    {
        public bx_agent GetAgent(int agentId)
        {
            var item = new bx_agent();
            try
            {
                using (var conn = DataFactory.DbService())
                {
                    item = conn.QueryFirstOrDefault<bx_agent>(string.Format("select * from bx_agent where id ={0}", agentId));
                }
            }
            catch (Exception ex)
            {
                //logError.Info("发生异常:" + ex.Source + "\n" + ex.StackTrace + "\n" + ex.Message + "\n" + ex.InnerException);
            }
            return item;
        }

        public int InsertAgent(List<bx_agent> list)
        {
            StringBuilder sql = new StringBuilder();
            if (list != null && list.Any())
            {
                foreach (var item in list)
                {
                    sql.Append($"insert into bx_agent (Id,AgentName,Mobile,OpenId,ShareCode,CreateTime,IsBigAgent,FlagId,ParentAgent,ParentRate,AgentRate,ReviewRate,PayType,AgentGetPay,CommissionType,ParentShareCode,IsUsed,AgentAccount,AgentPassWord,IsGenJin,IsDaiLi,IsShow,IsShowCalc,SecretKey,IsLiPei,AgentType,MessagePayType,Region,BatchRenewalTotalCount,ManagerRoleId,BatchRenewalFrequency,AgentAddress,RegType,IsQuote,IsSubmit,TopAgentId,ClientName,PurchasedCommodity,agent_level,commodity,platform,repeat_quote,EffectiveCallDuration,endDate,accountType,openQuote,loginType,robotCount,agentBrand,contractEndDate,quoteCompany,phone_is_wechat,hide_phone,group_id,picc_account,zhen_bang_type,charge_person,zs_type,bxShop) values ('{item.Id}','{item.AgentName}','{item.Mobile}','{item.OpenId}','{item.ShareCode}','{item.CreateTime}','{item.IsBigAgent}','{item.FlagId}','{item.ParentAgent}','{item.ParentRate}','{item.AgentRate}','{item.ReviewRate}','{item.PayType}','{item.AgentGetPay}','{item.CommissionType}','{item.ParentShareCode}','{item.IsUsed}','{item.AgentAccount}','{item.AgentPassWord}','{item.IsGenJin}','{item.IsDaiLi}','{item.IsShow}','{item.IsShowCalc}','{item.SecretKey}','{item.IsLiPei}','{item.AgentType}','{item.MessagePayType}','{item.Region}','{item.BatchRenewalTotalCount}','{item.ManagerRoleId}','{item.BatchRenewalFrequency}','{item.AgentAddress}','{item.RegType}','{item.IsQuote}','{item.IsSubmit}','{item.TopAgentId}','{item.ClientName}','{item.PurchasedCommodity}','{item.agent_level}','{item.commodity}','{item.platform}','{item.repeat_quote}','{item.EffectiveCallDuration}','{item.endDate}','{item.accountType}','{item.openQuote}','{item.loginType}','{item.robotCount}','{item.agentBrand}','{item.contractEndDate}','{item.quoteCompany}','{item.phone_is_wechat}','{item.hide_phone}','{item.group_id}','{item.picc_account}','{item.zhen_bang_type}','{item.charge_person}','{item.zs_type}','{item.bxShop}');");
                }
            }
            if (sql.Length == 0) {
                return 0;
            }
            try
            {
                using (var conn = DataFactory.DbService())
                {
                    return conn.Execute(sql.ToString());
                }
            }
            catch(Exception ex) { }
            return 0;
        }
    }
}
