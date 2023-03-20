using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{   
    public class Amulet
    {      
        private string itemId;
        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
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
            this.itemId = ItemId;
            this.quality = Quality;
            this.design = Design;           
        }
        public Amulet(string ItemId) :
            this(ItemId, Level.medium,"")
        {         
        }
        public Amulet(string ItemId, Level Quality) : 
            this(ItemId, Quality,"")
        {        
        }
        public override string ToString()
        {          
            return $"ItemId: {itemId}, Quality: {quality}, Design: {design}";
        }
    }
}
