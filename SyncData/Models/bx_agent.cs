
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncData.Models
{
    public partial class bx_agent
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public string Mobile { get; set; }
        public string OpenId { get; set; }
        public string ShareCode { get; set; }
        private string? _CreateTime;
        public string? CreateTime { get { if (string.IsNullOrEmpty(_CreateTime)) return DateTime.MinValue.ToString(); else { return _CreateTime; } } set {  _CreateTime = value; } } 
        private string? _IsBigAgent;
        public string? IsBigAgent { get { if (string.IsNullOrEmpty(_IsBigAgent)) return "0"; else { return _IsBigAgent; } } set {  _IsBigAgent = value; } } 
        private string? _FlagId;
        public string? FlagId { get { if (string.IsNullOrEmpty(_FlagId)) return "0"; else { return _FlagId; } } set { _FlagId = value; } } 
        public int ParentAgent { get; set; }
        private string? _ParentRate;
        public string? ParentRate { get { if (string.IsNullOrEmpty(_ParentRate)) return "0"; else { return _ParentRate; } } set {  _ParentRate = value; } } 
        private string? _AgentRate;
        public string? AgentRate { get { if (string.IsNullOrEmpty(_AgentRate)) return "0"; else { return _AgentRate; } } set { _AgentRate = value; } } 
        private string? _ReviewRate;
        public string? ReviewRate { get { if (string.IsNullOrEmpty(_ReviewRate)) return "0"; else { return _ReviewRate; } } set {_ReviewRate = value; } } 
        private string? _PayType;
        public string? PayType { get { if (string.IsNullOrEmpty(_PayType)) return "0"; else { return _PayType; } } set { _PayType = value; } } 
        private string? _AgentGetPay;
        public string? AgentGetPay { get { if (string.IsNullOrEmpty(_AgentGetPay)) return "0"; else { return _AgentGetPay; } } set {  _AgentGetPay = value; } } 
        private string? _CommissionType;
        public string? CommissionType { get { if (string.IsNullOrEmpty(_CommissionType)) return "0"; else { return _CommissionType; } } set {  _CommissionType = value; } } 
        public string ParentShareCode { get; set; }
        private string? _IsUsed;
        public string? IsUsed { get { if (string.IsNullOrEmpty(_IsUsed)) return "0"; else { return _IsUsed; } } set {  _IsUsed = value; } } 
        public string AgentAccount { get; set; }
        public string AgentPassWord { get; set; }
        private string? _IsGenJin;
        public string? IsGenJin { get { if (string.IsNullOrEmpty(_IsGenJin)) return "0"; else { return _IsGenJin; } } set { _IsGenJin = value; } } 
        private string? _IsDaiLi;
        public string? IsDaiLi { get { if (string.IsNullOrEmpty(_IsDaiLi)) return "0"; else { return _IsDaiLi; } } set { _IsDaiLi = value; } } 
        private string? _IsShow;
        public string? IsShow { get { if (string.IsNullOrEmpty(_IsShow)) return "0"; else { return _IsShow; } } set {  _IsShow = value; } } 
        private string? _IsShowCalc;
        public string? IsShowCalc { get { if (string.IsNullOrEmpty(_IsShowCalc)) return "0"; else { return _IsShowCalc; } } set {  _IsShowCalc = value; } } 
        public string SecretKey { get; set; }
        private string? _IsLiPei;
        public string? IsLiPei { get { if (string.IsNullOrEmpty(_IsLiPei)) return "0"; else { return _IsLiPei; } } set {  _IsLiPei = value; } } 
        private string? _AgentType;
        public string? AgentType { get { if (string.IsNullOrEmpty(_AgentType)) return "0"; else { return _AgentType; } } set { _AgentType = value; } } 
        private string? _MessagePayType;
        public string? MessagePayType { get { if (string.IsNullOrEmpty(_MessagePayType)) return "0"; else { return _MessagePayType; } } set { _MessagePayType = value; } } 
        public string Region { get; set; }
        public int BatchRenewalTotalCount { get; set; }
        public int ManagerRoleId { get; set; }
        public int BatchRenewalFrequency { get; set; }
        public string AgentAddress { get; set; }
        private string? _RegType;
        public string? RegType { get { if (string.IsNullOrEmpty(_RegType)) return "0"; else { return _RegType; } } set {  _RegType = value; } } 
        public int IsQuote { get; set; }
        public int IsSubmit { get; set; }
        public int TopAgentId { get; set; }
        public string ClientName { get; set; }
        public string PurchasedCommodity { get; set; }
        public int agent_level { get; set; }
        public int commodity { get; set; }
        public int platform { get; set; }
        public int repeat_quote { get; set; }
        public int EffectiveCallDuration { get; set; }
        private string? _endDate;
        public string? endDate { get { if (string.IsNullOrEmpty(_endDate)) return DateTime.MinValue.ToString(); else { return _endDate; } } set {  _endDate = value; } } 
        public int accountType { get; set; }
        public int openQuote { get; set; }
        public int loginType { get; set; }
        public int robotCount { get; set; }
        public string agentBrand { get; set; }
        private string? _contractEndDate;
        public string? contractEndDate { get { if (string.IsNullOrEmpty(_contractEndDate)) return DateTime.MinValue.ToString(); else { return _contractEndDate; } } set { _contractEndDate = value; } } 
        public int quoteCompany { get; set; }
        public int phone_is_wechat { get; set; }
        public int hide_phone { get; set; }
        private string? _group_id;
        public string? group_id { get { if (string.IsNullOrEmpty(_group_id)) return "0"; else { return _group_id; } } set { _group_id = value; } } 
        public int picc_account { get; set; }
        public int zhen_bang_type { get; set; }
        public string charge_person { get; set; }
        public int zs_type { get; set; }
        public int bxShop { get; set; }
    }
}
