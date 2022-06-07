using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodCourtManagementSystem
{
    public class User
    {
        public void loginAs()
        {
        menu:
            Console.WriteLine("---------------Admin----------------------");
            Console.WriteLine(" Manage Food Item Press                        : 1");
            Console.WriteLine(" Manage Food Category Press                    : 2");
            Console.WriteLine(" Manage  Sales Press                           : 3");
            Console.WriteLine(" Report of Food Court Management System Press  : 4");
            Console.WriteLine(" Exit Press                                    : 5");
            Console.WriteLine("______________________________________");
            int user = Convert.ToInt32(Console.ReadLine());
            switch (user)
            {
                case 1:
                    {
                    Items:
                        FoodItems();
                        ManageFoodItems obj = new ManageFoodItems();
                        int input = Convert.ToInt32(Console.ReadLine());
                        switch (input)
                        {
                            case 1:
                                obj.AddingFood();
                                goto Items;
                            case 2:
                                obj.EditFoodItem();
                                goto Items;
                            case 3:
                                obj.ViewDetailsOfFood();
                                goto Items;

                            case 4:
                                obj.ListOfAllFoodItem();
                                goto Items;

                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto Items;


                        }
                    }
                    break;
                case 2:
                    {
                    Category:
                        FoodCategory();
                        ManageFoodCategory obj1 = new ManageFoodCategory();
                        int choise = Convert.ToInt32(Console.ReadLine());
                        switch (choise)
                        {
                            case 1:
                                obj1.AddingFoodCategory();
                                goto Category;
                            case 2:
                                obj1.EditCategory();
                                goto Category;
                            case 3:
                                obj1.ViewDetailsOfFoodCategory();
                                goto Category;
                            case 4:
                                obj1.ListOfAllFoodCategory();
                                goto Category;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto Category; ;
                        }
                    }
                    break;
               
                    
                case 3:
                    {
                    Sales:
                        FoodSales();
                        ManageSales obj2 = new ManageSales();
                        int choise1 = Convert.ToInt32(Console.ReadLine());
                        switch (choise1)
                        {
                            case 1:
                                obj2.AddingNewSales();
                                goto Sales;
                            case 2:
                                obj2.EditSales();
                                goto Sales;
                            case 3:
                                obj2.ViewDetailsOfSales();
                                goto Sales;
                            case 4:
                                obj2.ListOfAllsales();
                                goto Sales;
                            case 5:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Invalid Choise ");
                                goto Sales; ;
                        }
                    }
                    break;
                
                case 4:
                Report:
                    Report();
                    Report obj3 = new Report();
                    int choise2 = Convert.ToInt32(Console.ReadLine());
                    switch (choise2)
                    {
                        case 1:
                            obj3.ReportOfAllFoodItem();
                            goto Report;
                        case 2:
                            obj3.ReportOfAllFoodCategory();
                            goto Report;
                        case 3:
                            obj3.ReportOfAllFoodsales();
                            goto Report;
                        
                        case 4:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choise ");
                            goto Report; ;
                    }
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine(" bad Input ");
                    Console.WriteLine("try Again");
                    goto menu;


            }


        }


        private void FoodItems()
        {
            Console.WriteLine("----------------Food Items----------------");
            Console.WriteLine("Adding New Food Item Press          : 1");
            Console.WriteLine("Edit The Existing Food Item Press   : 2");
            Console.WriteLine("View Details of the Food Item Press : 3");
            Console.WriteLine("Listing of all Food Item Press      : 4");
            Console.WriteLine("Exit Press 5");
        }
        private void FoodCategory()
        {
            Console.WriteLine("----------------Food Category----------------");
            Console.WriteLine("Adding New Food Category Press          : 1");
            Console.WriteLine("Edit The Existing Food Category Press   : 2");
            Console.WriteLine("View Details of the Food Category Press : 3");
            Console.WriteLine("Listing of all Food Category Press      : 4");
            Console.WriteLine("Exit Press 5");
        }
      
        private void FoodSales()
        {
            Console.WriteLine("----------------Food Sales----------------");
            Console.WriteLine("Adding New Sales Press          : 1");
            Console.WriteLine("Edit The Existing Sales Press   : 2");
            Console.WriteLine("View Details of the Sales Press : 3");
            Console.WriteLine("Listing of all Sales Press      : 4");
            Console.WriteLine("Exit Press                      : 5");
        }
        private void Report()
        {
            Console.WriteLine("----------------Report----------------");
            Console.WriteLine("Report of all Food Item Press       : 1");
            Console.WriteLine("Report of all Food Category Press   : 2");
            Console.WriteLine("Report of all Sales Press           : 3");
            Console.WriteLine("Exit Press                          : 4");
        }

    }
}
