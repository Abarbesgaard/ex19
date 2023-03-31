using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disaheim;


namespace Disaheim
{
    //public class Utility
    //{
        //private double lowQualityValue = 12.5;

        //public double LowQualityValue
        //{
        //    get { return lowQualityValue; }
        //    set { lowQualityValue = value; }
        //}

        //private double mediumQualityValue = 20.0;

        //public double MediumQualityValue
        //{
        //    get { return mediumQualityValue; }
        //    set { mediumQualityValue =  value; }
        //}

        //private double highQualityValue = 27.5;
            
        //public double HighQualityValue
        //{
        //    get { return highQualityValue; }
        //    set { highQualityValue = value; }
        //}


        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}


        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    double price = 0.0;
        //    if (amulet.Quality == Level.low)
        //        price = LowQualityValue;
        //    else if (amulet.Quality == Level.medium)
        //        price = MediumQualityValue;
        //    else if (amulet.Quality == Level.high)
        //        price = HighQualityValue;

        //    return price;
        //}

    //    public double GetValueOfMerchandise(Merchandise merchandise)
    //    {
            
    //        if (merchandise.GetType() == typeof(Book))
    //            //x = (merchandise as Book).Price;
    //            return GetValueOfBook(merchandise as Book);

    //        else if (merchandise.GetType() == typeof(Amulet))
    //        {
    //            return GetValueOfAmulet(merchandise as Amulet);
    //            //if ((merchandise as Amulet).Quality == Level.low)
    //            //    x = 12.5;
    //            //else if ((merchandise as Amulet).Quality == Level.medium)
    //            //    x = 20.0;
    //            //else if ((merchandise as Amulet).Quality == Level.high)
    //            //    x = 27.5;
    //        }
    //        return 0;

    //        //if (merchandise.GetType() == typeof(Book))
    //        //    return GetValueOfBook(merchandise as Book);
    //        //else if (merchandise.GetType() == typeof(Book))
    //        //    return GetValueOfAmulet(merchandise as Amulet);
    //        //return 0;
    //    }

    //    public double GetValueOfCourse(Course course)
    //    {
    //        //double price = 0.0;
    //        //int m = course.DurationInMinutes;
    //        ////for hver påbegyndt time skal der lægges 875.00 til
    //        //if (m == 0)
    //        //    price = 0;
    //        //else if (m >= 1 && m <= 60)
    //        //    price = 875.00;
    //        //else if (m >= 61 && m <= 120)
    //        //    price = 875.00 * 2;
    //        //else if (m >= 121 && m <= 240)
    //        //    price = 875.00 * 3;
    //        double pris = (int)((course.DurationInMinutes + 59) / 60) * CourseHourValue;


    //        return pris;
    //    }
    //}
}
