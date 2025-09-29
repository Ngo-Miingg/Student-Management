using Microsoft.AspNetCore.Mvc.Rendering;

namespace Student_management.Models
{
    public class MyScheduleViewModel
    {
        public string TenGiaoVien { get; set; } = "";
        public string TenHocKy { get; set; } = "";
        // <<< THÊM CÁC THUỘC TÍNH MỚI >>>
        public int SelectedHocKyId { get; set; }
        public List<SelectListItem> HocKyOptions { get; set; } = new List<SelectListItem>();
        // <<< KẾT THÚC PHẦN THÊM >>>
        public Dictionary<string, Dictionary<int, Lichhoc>> TimetableGrid { get; set; } = new();
    }
}