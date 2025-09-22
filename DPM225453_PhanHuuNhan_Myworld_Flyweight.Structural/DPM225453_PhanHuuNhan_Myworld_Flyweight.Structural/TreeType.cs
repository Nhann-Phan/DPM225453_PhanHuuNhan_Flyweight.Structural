using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld_Flyweight.Structural
{
    public abstract class TreeType
    {
        // Trạng thái nội tại (Intrinsic State) - chung cho tất cả cây cùng loại
        protected string Ten;
        protected string MauSac;
        protected string Anh;

        // Hành động nhận vào trạng thái ngoại lai
        public abstract void Draw(int x, int y);
    }
}
