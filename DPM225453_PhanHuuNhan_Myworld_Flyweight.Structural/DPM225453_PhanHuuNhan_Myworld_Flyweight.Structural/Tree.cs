using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld_Flyweight.Structural
{
    public class Tree
    {
        private int X;
        private int Y;
        private TreeType Type; // Tham chiếu đến đối tượng Flyweight được chia sẻ

        public Tree(int x, int y, TreeType type)
        {
            this.X = x;
            this.Y = y;
            this.Type = type;
        }

        public void Draw()
        {
            // Ủy quyền việc vẽ cho đối tượng flyweight, truyền vào trạng thái ngoại lai của nó
            Type.Draw(X, Y);
        }
    }
}
