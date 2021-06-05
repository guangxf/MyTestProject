﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWeb.Models
{
    public partial class bx_lastinfo
    {
        public long id { get; set; }
        public Nullable<long> b_uid { get; set; }
        public string last_end_date { get; set; }
        public Nullable<double> nonclaim_discount_rate { get; set; }
        public Nullable<int> last_year_acctimes { get; set; }
        public Nullable<double> last_year_claimamount { get; set; }
        public Nullable<int> last_year_claimtimes { get; set; }
        public Nullable<int> service_update { get; set; }
        public string last_business_end_date { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<double> LastYearBizClaimAmount { get; set; }
        public Nullable<int> LastYearBizClaimTimes { get; set; }
        public Nullable<double> LastYearForceClaimAmount { get; set; }
        public Nullable<int> LastYearForceClaimTimes { get; set; }
    }
}
