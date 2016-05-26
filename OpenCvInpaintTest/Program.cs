using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenCvInpaintTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var img = new IplImage(@"Images/1.jpg"))
            using (var mask = new IplImage(@"Images/1_mask.png", LoadMode.GrayScale))
            using (var dst = new IplImage(img.Size, BitDepth.U8, 3))
            {
                // Inpaintメソッドで不要領域の除去をする
                Cv.Inpaint(img, mask, dst, 10.0, InpaintMethod.NS);
                // 結果をウィンドウで表示
                CvWindow.ShowImages(dst);
            }
        }
    }
}
