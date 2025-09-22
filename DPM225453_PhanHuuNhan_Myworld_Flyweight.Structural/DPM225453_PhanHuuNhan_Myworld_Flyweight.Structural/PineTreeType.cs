using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DPM225453_PhanHuuNhan_Myworld_Flyweight.Structural
{
    public class PineTreeType : TreeType
    {
        public PineTreeType()
        {
            Ten = "Le";
            MauSac = "Xanh Dam";
            Anh = "PineTexture.png";
        }

        public override void Draw(int x, int y)
        {
            // Trạng thái ngoại lai (x, y) được truyền vào từ bên ngoài
            Console.WriteLine($"Vẽ cây {Ten} voi anh {Anh} tai ({x}, {y})");
        }
    }
}
