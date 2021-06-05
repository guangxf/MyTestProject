using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncData.Models
{
    public partial class bx_carinfo
    {
        public long id { get; set; }
        public string license_no { get; set; }
        public string engine_no { get; set; }
        public string vin_no { get; set; }
        public string mold_name { get; set; }
        private string? _register_date;
        public string? register_date { get { if (string.IsNullOrEmpty(_register_date)) return DateTime.MinValue.ToShortDateString(); else { return _register_date; } } set { _register_date = value; } }
        public string owner_idno { get; set; }
        public string license_owner { get; set; }
        private string? _owner_idno_type;
        public string? owner_idno_type { get { if (string.IsNullOrEmpty(_owner_idno_type)) return "0"; else { return _owner_idno_type; } } set { _owner_idno_type = value; } }
        private string? _license_type;
        public string? license_type { get { if (string.IsNullOrEmpty(_license_type)) return "0"; else { return _license_type; } } set { _license_type = value; } }
        private string? _car_type;
        public string? car_type { get { if (string.IsNullOrEmpty(_car_type)) return "0"; else { return _car_type; } } set { _car_type = value; } }
        private string? _car_used_type;
        public string? car_used_type { get { if (string.IsNullOrEmpty(_car_used_type)) return "0"; else { return _car_used_type; } } set { _car_used_type = value; } }
        private string? _seat_count;
        public string? seat_count { get { if (string.IsNullOrEmpty(_seat_count)) return "0"; else { return _seat_count; } } set { _seat_count = value; } }
        private string? _exhaust_scale;
        public string? exhaust_scale { get { if (string.IsNullOrEmpty(_exhaust_scale)) return "0"; else { return _exhaust_scale; } } set { _exhaust_scale = value; } }
        private string? _car_equ_quality;
        public string? car_equ_quality { get { if (string.IsNullOrEmpty(_car_equ_quality)) return "0"; else { return _car_equ_quality; } } set { _car_equ_quality = value; } }
        private string? _car_ton_count;
        public string? car_ton_count { get { if (string.IsNullOrEmpty(_car_ton_count)) return "0"; else { return _car_ton_count; } } set { _car_ton_count = value; } }
        private string? _purchase_price;
        public string? purchase_price { get { if (string.IsNullOrEmpty(_purchase_price)) return "0"; else { return _purchase_price; } } set { _purchase_price = value; } }
        private string? _fuel_type;
        public string? fuel_type { get { if (string.IsNullOrEmpty(_fuel_type)) return "0"; else { return _fuel_type; } } set { _fuel_type = value; } }
        private string? _proof_type;
        public string? proof_type { get { if (string.IsNullOrEmpty(_proof_type)) return "0"; else { return _proof_type; } } set { _proof_type = value; } }
        private string? _license_color;
        public string? license_color { get { if (string.IsNullOrEmpty(_license_color)) return "0"; else { return _license_color; } } set { _license_color = value; } }
        private string? _clause_type;
        public string? clause_type { get { if (string.IsNullOrEmpty(_clause_type)) return "0"; else { return _clause_type; } } set { _clause_type = value; } }
        private string? _run_region;
        public string? run_region { get { if (string.IsNullOrEmpty(_run_region)) return "0"; else { return _run_region; } } set { _run_region = value; } }
        private string? _create_time;
        public string? create_time { get { if (string.IsNullOrEmpty(_create_time)) return DateTime.MinValue.ToString(); else { return _create_time; } } set { _create_time = value; } }
        private string? _update_time;
        public string? update_time { get { if (string.IsNullOrEmpty(_update_time)) return DateTime.MinValue.ToString(); else { return _update_time; } } set { _update_time = value; } }
        private string? _transfer_date;
        public string? transfer_date { get { if (string.IsNullOrEmpty(_transfer_date)) return DateTime.MinValue.ToString(); else { return _transfer_date; } } set { _transfer_date = value; } }
        public string auto_model_code { get; set; }
        public string VehicleYear { get; set; }
        public string drivelicense_caryype_value { get; set; }
        public string drivelicense_cartype_name { get; set; }
        private string? _RenewalCarType;
        public string? RenewalCarType { get { if (string.IsNullOrEmpty(_RenewalCarType)) return "0"; else { return _RenewalCarType; } } set { _RenewalCarType = value; } }
        private string? _OwnerSex;
        public string? OwnerSex { get { if (string.IsNullOrEmpty(_OwnerSex)) return "0"; else { return _OwnerSex; } } set { _OwnerSex = value; } }
        public string OwnerBirthday { get; set; }
        private string? _analogy_price;
        public string? analogy_price { get { if (string.IsNullOrEmpty(_analogy_price)) return "0"; else { return _analogy_price; } } set { _analogy_price = value; } }
        public string pa_auto_model_code { get; set; }
        public string BrandName { get; set; }
        public string VehiclesName { get; set; }
    }
}
