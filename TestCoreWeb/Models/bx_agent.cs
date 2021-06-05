using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWeb.Models
{
    public partial class bx_agent
    {
        public int Id { get; set; }
        public string AgentName { get; set; }
        public string Mobile { get; set; }
        public string OpenId { get; set; }
        public string ShareCode { get; set; }
        private string? _CreateTime;
        public string? CreateTime { get { return _CreateTime; } set { if (string.IsNullOrEmpty(_CreateTime)) _CreateTime = DateTime.MinValue.ToString(); else { _CreateTime = value; } } }
        public string? IsBigAgent { get; set; }
        private string? _FlagId;
        public string? FlagId { get { return _FlagId; } set { if (string.IsNullOrEmpty(_FlagId)) _FlagId = "0"; else { _FlagId = value; } } }
        public int ParentAgent { get; set; }
        private string? _ParentRate;
        public string? ParentRate { get { return _ParentRate; } set { if (string.IsNullOrEmpty(_ParentRate)) _ParentRate = "0"; else { _ParentRate = value; } } }
        private string? _AgentRate;
        public string? AgentRate { get { return _AgentRate; } set { if (string.IsNullOrEmpty(_AgentRate)) _AgentRate = "0"; else { _AgentRate = value; } } }
        private string? _ReviewRate;
        public string? ReviewRate { get { return _ReviewRate; } set { if (string.IsNullOrEmpty(_ReviewRate)) _ReviewRate = "0"; else { _ReviewRate = value; } } }
        private string? _PayType;
        public string? PayType { get { return _PayType; } set { if (string.IsNullOrEmpty(_PayType)) _PayType = "0"; else { _PayType = value; } } }
        private string? _AgentGetPay;
        public string? AgentGetPay { get { return _AgentGetPay; } set { if (string.IsNullOrEmpty(_AgentGetPay)) _AgentGetPay = "0"; else { _AgentGetPay = value; } } }
        private string? _CommissionType;
        public string? CommissionType { get { return _CommissionType; } set { if (string.IsNullOrEmpty(_CommissionType)) _CommissionType = "0"; else { _CommissionType = value; } } }
        public string ParentShareCode { get; set; }
        private string? _IsUsed;
        public string? IsUsed { get { return _IsUsed; } set { if (string.IsNullOrEmpty(_IsUsed)) _IsUsed = "0"; else { _IsUsed = value; } } }
        public string AgentAccount { get; set; }
        public string AgentPassWord { get; set; }
        private string? _IsGenJin;
        public string? IsGenJin { get { return _IsGenJin; } set { if (string.IsNullOrEmpty(_IsGenJin)) _IsGenJin = "0"; else { _IsGenJin = value; } } }
        private string? _IsDaiLi;
        public string? IsDaiLi { get { return _IsDaiLi; } set { if (string.IsNullOrEmpty(_IsDaiLi)) _IsDaiLi = "0"; else { _IsDaiLi = value; } } }
        private string? _IsShow;
        public string? IsShow { get { return _IsShow; } set { if (string.IsNullOrEmpty(_IsShow)) _IsShow = "0"; else { _IsShow = value; } } }
        private string? _IsShowCalc;
        public string? IsShowCalc { get { return _IsShowCalc; } set { if (string.IsNullOrEmpty(_IsShowCalc)) _IsShowCalc = "0"; else { _IsShowCalc = value; } } }
        public string SecretKey { get; set; }
        private string? _IsLiPei;
        public string? IsLiPei { get { return _IsLiPei; } set { if (string.IsNullOrEmpty(_IsLiPei)) _IsLiPei = "0"; else { _IsLiPei = value; } } }
        private string? _AgentType;
        public string? AgentType { get { return _AgentType; } set { if (string.IsNullOrEmpty(_AgentType)) _AgentType = "0"; else { _AgentType = value; } } }
        private string? _MessagePayType;
        public string? MessagePayType { get { return _MessagePayType; } set { if (string.IsNullOrEmpty(_MessagePayType)) _MessagePayType = "0"; else { _MessagePayType = value; } } }
        public string Region { get; set; }
        public int BatchRenewalTotalCount { get; set; }
        public int ManagerRoleId { get; set; }
        public int BatchRenewalFrequency { get; set; }
        public string AgentAddress { get; set; }
        private string? _RegType;
        public string? RegType { get { return _RegType; } set { if (string.IsNullOrEmpty(_RegType)) _RegType = "0"; else { _RegType = value; } } }
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
        public string? endDate { get { return _endDate; } set { if (string.IsNullOrEmpty(_endDate)) _endDate = DateTime.MinValue.ToString(); else { _endDate = value; } } }
        public int accountType { get; set; }
        public int openQuote { get; set; }
        public int loginType { get; set; }
        public int robotCount { get; set; }
        public string agentBrand { get; set; }
        private string? _contractEndDate;
        public string? contractEndDate { get { return _contractEndDate; } set { if (string.IsNullOrEmpty(_contractEndDate)) _contractEndDate = DateTime.MinValue.ToString(); else { _contractEndDate = value; } } }
        public int quoteCompany { get; set; }
        public int phone_is_wechat { get; set; }
        public int hide_phone { get; set; }
        private string? _group_id;
        public string? group_id { get { return _group_id; } set { if (string.IsNullOrEmpty(_group_id)) _group_id = "0"; else { _group_id = value; } } }
        public int picc_account { get; set; }
        public int zhen_bang_type { get; set; }
        public string charge_person { get; set; }
        public int zs_type { get; set; }
        public int bxShop { get; set; }
    }
}
