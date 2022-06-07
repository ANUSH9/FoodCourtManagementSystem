using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    internal class ManageSales
    {
        public void AddingNewSales()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\sales.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Add New Sales");
            sw.Write(Console.ReadLine());
            Console.WriteLine("ReEnter");
            FileStream fss = new FileStream("F:\\New folder\\managefooditem\\salesadd.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ssw = new StreamWriter(fss);
            Console.Write("Add New Sales");
            ssw.Write(Console.ReadLine());


            ssw.Close();
            fss.Close();


            sw.Close();
            fs.Close();

        }
        public void ViewDetailsOfSales()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\salesadd.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("View Details Of All Food sales");
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
        public void ListOfAllsales()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\sales.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("List Of All Food sales");
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
        public void EditSales()
        {

        }
    }
}
