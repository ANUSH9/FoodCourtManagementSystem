using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    public class ManageFoodItems
    {
        public void ViewDetailsOfFood()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\foodadd.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("View Details Of All Food Item");
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
        public void ListOfAllFoodItem()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\food.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            Console.WriteLine("List Of All Food Item");
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
        public void AddingFood()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\food.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Adding New Food Item:");
            sw.Write(Console.ReadLine());
            Console.WriteLine("ReEnter");
            FileStream fss = new FileStream("F:\\New folder\\managefooditem\\foodadd.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ssw = new StreamWriter(fss);
            Console.Write("Adding New Food Item:");
            ssw.Write(Console.ReadLine());


            ssw.Close();
            fss.Close();


            sw.Close();
            fs.Close();
            

            
        }
        public void EditFoodItem()
        {
            FileStream fs = new FileStream("F:\\New folder\\managefooditem\\food.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.Write("Food Item:");
            sw.Write(Console.ReadLine());
            Console.WriteLine("ReEnter");
            FileStream fss = new FileStream("F:\\New folder\\managefooditem\\foodadd.txt", FileMode.Create, FileAccess.Write);
            StreamWriter ssw = new StreamWriter(fss);
            Console.WriteLine("Food Item:");
            ssw.Write(Console.ReadLine());


            ssw.Close();
            fss.Close();


            sw.Close();
            fs.Close();
        }
    }
       
        

         

    


}
