using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class Report
    {
        public void ReportOfAllFoodsales()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\sales.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Report Of all Food sales");
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line != "")
                    if (!line.StartsWith(" "))
                    {
                        string[] myStrs = line.Split(',');

                        Console.WriteLine(myStrs[0] + "\t" + myStrs[1]);
                    }
            }
        }
        public void ReportOfAllFoodCategory()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\foodcategory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("List Of All Food category");
            Console.WriteLine("Food Categgory" + "\t" + "Food name");
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine(); //studid
                if (line != "")
                    if (!line.EndsWith("Date"))
                    {
                        string[] myStrs = line.Split(',');

                        Console.WriteLine(myStrs[0] + "\t" + myStrs[1]);
                    }
            }
        }
        public void ReportOfAllFoodItem()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\food.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("Report Of All Food Item ");
            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine();
                if (line != "")
                    if (!line.StartsWith("Book"))
                    {
                        string[] myStrs = line.Split(',');

                        Console.WriteLine(myStrs[0] + "\t" + myStrs[1]);
                    }
            }
        }
    }
}
