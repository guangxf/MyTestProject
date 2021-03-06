﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCoreWeb.Models
{
    public partial class bx_carinfo
    {
        public long id { get; set; }
        public string license_no { get; set; }
        public string engine_no { get; set; }
        public string vin_no { get; set; }
        public string mold_name { get; set; }
        public Nullable<System.DateTime> register_date { get; set; }
        public string owner_idno { get; set; }
        public string license_owner { get; set; }
        public Nullable<int> owner_idno_type { get; set; }
        public Nullable<int> license_type { get; set; }
        public Nullable<int> car_type { get; set; }
        public Nullable<int> car_used_type { get; set; }
        public Nullable<int> seat_count { get; set; }
        public Nullable<decimal> exhaust_scale { get; set; }
        public Nullable<decimal> car_equ_quality { get; set; }
        public Nullable<decimal> car_ton_count { get; set; }
        public Nullable<decimal> purchase_price { get; set; }
        public Nullable<int> fuel_type { get; set; }
        public Nullable<int> proof_type { get; set; }
        public Nullable<int> license_color { get; set; }
        public Nullable<int> clause_type { get; set; }
        public Nullable<int> run_region { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
        public Nullable<System.DateTime> transfer_date { get; set; }
        public string auto_model_code { get; set; }
        public string VehicleYear { get; set; }
        public string drivelicense_caryype_value { get; set; }
        public string drivelicense_cartype_name { get; set; }
        public Nullable<int> RenewalCarType { get; set; }
        public Nullable<int> OwnerSex { get; set; }
        public string OwnerBirthday { get; set; }
        public Nullable<decimal> analogy_price { get; set; }
        public string pa_auto_model_code { get; set; }
        public string BrandName { get; set; }
        public string VehiclesName { get; set; }
    }
}
