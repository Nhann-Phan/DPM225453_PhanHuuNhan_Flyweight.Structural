using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld_Flyweight.Structural
{
    public class TreeFactory
    {
        // Dùng Dictionary để lưu trữ các flyweight đã tạo (đóng vai trò là bộ nhớ cache)
        private Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

        public int TotalTypesCreated => treeTypes.Count;

        public TreeType GetTreeType(string name)
        {
            TreeType type = null;

            // Nếu loại cây này đã có trong cache, lấy ra dùng lại
            if (treeTypes.ContainsKey(name))
            {
                type = treeTypes[name];
            }
            else // Nếu chưa có, tạo mới, thêm vào cache rồi trả về
            {
                switch (name)
                {
                    case "Khom":
                        type = new PineTreeType();
                        break;
                    case "Xoi":
                        type = new OakTreeType();
                        break;
                        // Thêm các loại cây khác ở đây
                }
                if (type != null)
                {
                    treeTypes.Add(name, type);
                }
            }
            return type;
        }
    }
}
