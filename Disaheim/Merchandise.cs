using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Disaheim
{
    public abstract class Merchandise : IValuable
    {
        //public string ItemId { get; set; }
        private string itemId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }


        //public Merchandise(string itemId)
        //{
        //    this.ItemId = itemId;
        //}

        public abstract double GetValue();
        
        public virtual string ToString()
        {
            return $"ItemId: {itemId}";
        }
    }
}
