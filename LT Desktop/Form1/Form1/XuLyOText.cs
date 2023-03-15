using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    class XuLyOText
    {
        public static void suaChuoi(ref string chuoi)
        {
            string resultName = "";

            //Loại bỏ khoảng trắng giữa 2 đầu chuỗi.
            chuoi = chuoi.Trim();

            //Loai bỏ khoảng trắng thừa giữa các từ.
            while(chuoi.IndexOf("  ") != -1)
            {
                chuoi = chuoi.Replace("  ", " "); // Replace("Kí tự cũ", "Kí tự mới")
            }

            //Sao chép các ký tự của chuỗi vào 1 mảng.
            //Split: chia nhỏ một chuỗi tại dấu tách đã chỉ định và trả về các chuỗi con của nó.
            string[] arrayName = chuoi.Split(' ');

            //Duyệt các phần tử trong mảng, chuyển ký tự đầu tiên mỗi từ thành viết hoa, còn lại viết thưởng.
            for (int i = 0; i < arrayName.Length; i++)
            {
                //Substring(Int32, Int32): Chuỗi con bắt đầu tại một vị trí ký tự xác định và có độ dài xác định.
                //VD: Substring(0, 1)
                //ToUpper: Trả về một bản sao của chuỗi này được chuyển thành chữ hoa.
                //ToLower: Trả về một bản sao của chuỗi này được chuyển thành chữ thường.
                arrayName[i] = arrayName[i].Substring(0, 1).ToUpper() + arrayName[i].Substring(1).ToLower();
                resultName += arrayName[i].ToString() + " ";
            }

            chuoi = resultName;
        }
    }
}
