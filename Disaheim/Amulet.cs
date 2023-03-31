using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
    public class Amulet : Merchandise
    {

        private static double lowQualityValue = 12.5;

        public double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }

        private static double mediumQualityValue = 20.0;

        public double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }

        private static double highQualityValue = 27.5;


        public double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = value; }
        }




        private string design;
        public string Design
        {
            get { return design; }
            set { design = value; }
        }
        private Level quality;
        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }
        public Amulet(string ItemId, Level Quality, string Design) 
        {
            base.ItemId = ItemId;
            this.quality = Quality;
            this.design = Design;
        }
        public Amulet(string ItemId) :
            this(ItemId, Level.medium, "20")
        {
        }
        public Amulet(string ItemId, Level Quality) :
            this(ItemId, Quality, "Modern")
        {
        }
        
        public override double GetValue()
        {
            double price = 0.0;
            if (Quality == Level.low)
                price = LowQualityValue;
            else if (Quality == Level.medium)
                price = MediumQualityValue;
            else if (Quality == Level.high)
                price = HighQualityValue;

            return price;
        }
        
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {quality}, Design: {design}";
        }
    }
}
