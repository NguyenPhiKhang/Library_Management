using QLTV_BUS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV_GUI.HelpGUI
{
    public static class KiemTraDieuKien
    {
        //Tính tuổi
        public static int TinhTuoi(DateTime birthday)
        {
            DateTime now = DateTime.Now;
            int tuoi = now.Year - birthday.Year - 1;
            if (((now.Month == birthday.Month) && (now.Day >= birthday.Day)) || now.Month > birthday.Month)
                return tuoi + 1;
            return tuoi;
        }
        //Kiểm tra email có hợp lệ hay không?
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return true;
            else
                return false;
        }
        //Kiểm tra họ tên có hợp lệ hay không?
        public static bool isTen(string inputTen)
        {
            inputTen = inputTen ?? string.Empty;
            string strRegex = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            @"ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            @"ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s]+$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputTen))
                return true;
            else
                return false;
        }
        //Kiểm tra password có hợp lệ hay không?
        public static bool isPassword(string inputPassword)
        {
            inputPassword = inputPassword ?? string.Empty;
            //string strRegex = @"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=])(?=\S+$).{8,}$";
            string strRegex = @"^[0-9a-zA-Z@#$%^&+=,.]{8,}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputPassword))
                return true;
            else
                return false;
        }
        //Kiểm tra Username có hợp lệ hay không?
        public static bool isUsername(string inputUsername)
        {
            inputUsername = inputUsername ?? string.Empty;
            string strRegex = @"^[a-zA-Z0-9._-]{3,20}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputUsername))
                return true;
            else
                return false;
        }
        //Kiểm tra địa chỉ có hợp lệ hay không?
        public static bool isDiaChi(string inputDiaChi)
        {
            inputDiaChi = inputDiaChi ?? string.Empty;
            string strRegex = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶ" +
            @"ẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợ" +
            @"ụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s-]+$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputDiaChi))
                return true;
            else
                return false;
        }
        //Kiểm tra tuổi có hợp lệ hay không?
        public static bool Check_Tuoi(object ngaysinh)
        {
            int tuoi = TinhTuoi(Convert.ToDateTime(ngaysinh));
            if (tuoi >= THAMSOBUS.Instance.GetDSQuiDinh()[0].TuoiToiThieu && tuoi <= THAMSOBUS.Instance.GetDSQuiDinh()[0].TuoiToiDa)
                return true;
            return false;
        }
        //Kiểm tra text trùng
        public static bool Check_Trung(List<string> a, string b)
        {
            foreach (var item in a)
            {
                if (b == item)
                    return true;
            }
            return false;
        }
    }
}
