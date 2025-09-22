using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225453_PhanHuuNhan_Myworld_Flyweight.Structural
{
    public class Forest
    {
        public static void Main(string[] args)
        {
            // Danh sách để chứa tất cả các cây trong rừng
            List<Tree> forest = new List<Tree>();

            // Tạo nhà máy
            TreeFactory factory = new TreeFactory();

            Console.WriteLine("Planting 1000 trees...");

            // Trồng 500 cây thông
            for (int i = 0; i < 500; i++)
            {
                TreeType khomType = factory.GetTreeType("Khom");
                Tree Caykhom = new Tree(GetRandomCoordinate(), GetRandomCoordinate(), khomType);
                forest.Add(Caykhom);
            }

            // Trồng 500 cây sồi
            for (int i = 0; i < 500; i++)
            {
                TreeType xoiType = factory.GetTreeType("Xoi");
                Tree Cayxoi = new Tree(GetRandomCoordinate(), GetRandomCoordinate(), xoiType);
                forest.Add(Cayxoi);
            }

            Console.WriteLine("Drawing the forest...");

            // Vẽ cả khu rừng
            foreach (var tree in forest)
            {
                tree.Draw();
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Total trees in the forest: {forest.Count}");
            Console.WriteLine($"Total TreeType objects created (in memory): {factory.TotalTypesCreated}");
            Console.WriteLine("Memory saved!");

            Console.ReadKey();
        }

        private static int GetRandomCoordinate()
        {
            return new Random().Next(100);
        }
    }
}
