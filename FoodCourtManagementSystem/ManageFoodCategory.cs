using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    public class ManageFoodCategory
    {
        
        public void AddingFoodCategory()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\foodcategory.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Food Categgory");
            sw.Write(Console.ReadLine());
            Console.Write("Food Name");
            sw.Write(Console.ReadLine());
            Console.WriteLine("ReEnter");
            FileStream fss = new FileStream("F:\\New folder\\managefooditem\\foodcategoryadd.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ssw = new StreamWriter(fss);
            Console.Write("Food Categgory");
            ssw.Write(Console.ReadLine());
            Console.Write("Food Name");
            ssw.Write(Console.ReadLine());

            ssw.Close();
            fss.Close();

            sw.Close();
            fs.Close();



        }
        public void ViewDetailsOfFoodCategory()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\foodcategory.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
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
        public void ListOfAllFoodCategory()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\foodcategoryadd.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
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
        public void EditCategory()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\foodcategory.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            
            Console.Write("Food Name");
            sw.Write(Console.ReadLine());
            Console.WriteLine("ReEnter");
            FileStream fss = new FileStream("F:\\New folder\\managefooditem\\foodcategoryadd.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ssw = new StreamWriter(fss);
            
            Console.Write("Food Name");
            ssw.Write(Console.ReadLine());

            ssw.Close();
            fss.Close();

            sw.Close();
            fs.Close();

        }
    }
}
