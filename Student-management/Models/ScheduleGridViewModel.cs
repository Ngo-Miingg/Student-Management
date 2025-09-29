using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Student_management.Models
{
    public class ScheduleGridViewModel
    {
        // Dùng cho bộ lọc
        public int? SelectedLopId { get; set; }
        public List<SelectListItem> LopOptions { get; set; } = new List<SelectListItem>();

        // Dùng để hiển thị tiêu đề
        public string TenLopHienThi { get; set; } = "Tất cả các lớp";

        // Dữ liệu thời khóa biểu đã được xử lý thành dạng lưới
        // Key ngoài: Thứ trong tuần (vd: "Thứ Hai")
        // Key trong: Tiết học (vd: 1, 2, 3...)
        public Dictionary<string, Dictionary<int, Lichhoc>> TimetableGrid { get; set; }
            = new Dictionary<string, Dictionary<int, Lichhoc>>();
    }
}