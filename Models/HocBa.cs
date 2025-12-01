namespace DigHocBaUI.Models
{
    public class HocBa
    {
        public int STT { get; set; }
        public string MaDinhDanh { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string NgaySinh { get; set; } = "";

        // Dùng cho trang Khởi tạo & Ký số
        public string SoMonDaKy { get; set; } = "1/11";
        public string TrangThaiKhoiTao { get; set; } = ""; // Chưa khởi tạo (Đỏ), Đã khởi tạo (Đen)
        public string TrangThaiGVCN { get; set; } = "";     // Đợi ký (Đỏ), Đã ký (Đen)
        public string TrangThaiHieuTruong { get; set; } = "";

        // Dùng cho trang Ký số môn học
        public double DiemHK1 { get; set; }
        public double DiemHK2 { get; set; }
        public double DiemCaNam { get; set; }
        public string NguoiKy { get; set; } = "";
        public string TrangThaiKy { get; set; } = ""; // Đợi ký, Đã ký

        // Dùng cho trang Phát hành
        public string Lop { get; set; } = "";
        public string SoHocBaPhatHanh { get; set; } = "0/44";
        public bool IsBanHanh { get; set; } // Blue badge
        public bool IsChoXuLy { get; set; } // Yellow badge
    }
}