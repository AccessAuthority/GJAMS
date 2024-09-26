using System.ComponentModel.DataAnnotations;

namespace GJAMS.Models
{
    public class Result
    {
        [Key]
        public int id { get; set; }
        public string? name_of_post { get; set; }
        public string? post_date { get; set; }
        public string? short_info { get; set; }
        public string? online_link { get; set; }
        public string? notification_link { get; set; }
        public string? admitcard_link { get; set; }
        public string? result_link { get; set; }
        public string? official_link { get; set; }
        public string? organization_name { get; set; }
        public string? advertisement_no { get; set; }
        public string? imp_date1 { get; set; }
        public string? imp_date2 { get; set; }
        public string? imp_date3 { get; set; }
        public string? imp_date4 { get; set; }
        public string? imp_date5 { get; set; }
        public string? app_fee1 { get; set; }
        public string? app_fee2 { get; set; }
        public string? app_fee3 { get; set; }
        public string? app_fee4 { get; set; }
        public string? age_limit_as { get; set; }
        public string? age_limit1 { get; set; }
        public string? age_limit2 { get; set; }
        public string? age_limit3 { get; set; }
        public string? age_limit4 { get; set; }
        public string? age_limit5 { get; set; }
        public string? total_post { get; set; }
        public string? post_short_name { get; set; }
        public string? gen { get; set; }
        public string? ews { get; set; }
        public string? obc { get; set; }
        public string? sc { get; set; }
        public string? st { get; set; }
        public string? gender { get; set; }
        public string? post_eligibility1 { get; set; }
        public string? post_eligibility2 { get; set; }
        public string? post_eligibility3 { get; set; }
        public string? post_eligibility4 { get; set; }
        public string? post_eligibility5 { get; set; }
    }
}
