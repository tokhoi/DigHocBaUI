namespace DigHocBaUI.Models.SoDauBai
{
    public class DanhMucItem
    {
        public int STT { get; set; }
        public string Ma { get; set; } = "";
        public string Ten { get; set; } = "";
        public string MoTa { get; set; } = "";
        public bool TrangThai { get; set; } = true; // True: Sử dụng, False: Khóa
    }

    // 2. Dùng cho trang Lịch dạy & TKB
    public class LichDayItem
    {
        public string Thu { get; set; } = "";    // Thứ 2, 3...
        public int Tiet { get; set; }
        public string Lop { get; set; } = "";
        public string MonHoc { get; set; } = "";
        public string GiaoVien { get; set; } = "";
        public string LoaiLich { get; set; } = "Chính khóa"; // Dạy thay, Dạy bù...
        public string TrangThai { get; set; } = "Đã duyệt";
    }

    // 3. Dùng cho trang Cơ sở vật chất
    public class ThietBiItem
    {
        public int STT { get; set; }
        public string Ma { get; set; } = "";
        public string Ten { get; set; } = "";
        public string ViTri { get; set; } = "";
        public string TinhTrang { get; set; } = "Tốt"; // Tốt, Hỏng, Bảo trì...
    }
}