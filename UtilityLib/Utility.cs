//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Disaheim;


//namespace UtilityLib
//{
//    public class Utility
//    {
        
//        public double GetValueOfBook(Book book)
//        {

//            return book.Price;
//        }

//        public double GetValueOfAmulet(Amulet amulet)
//        {

//            double price = 0.0;

//            if (amulet.Quality == Level.low)
//                price = 12.5;
//            else if (amulet.Quality == Level.medium)
//                price = 20.0;
//            else if (amulet.Quality == Level.high)
//                price = 27.5;

//            return price;
//        }

//        public double GetValueOfCourse(Course course)
//        {
//            //double price = 0.0;
//            //int m = course.DurationInMinutes;
//            ////for hver påbegyndt time skal der lægges 875.00 til
//            //if (m == 0)
//            //    price = 0;
//            //else if (m >= 1 && m <= 60)
//            //    price = 875.00;
//            //else if (m >= 61 && m <= 120)
//            //    price = 875.00 * 2;
//            //else if (m >= 121 && m <= 240)
//            //    price = 875.00 * 3;
//            double pris = (int)((course.DurationInMinutes + 59) / 60) * 875;
            

//            return pris;
//        }
//    }
//}
