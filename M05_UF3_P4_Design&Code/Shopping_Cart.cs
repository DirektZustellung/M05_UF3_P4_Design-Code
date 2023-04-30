using System;
using System.Collections.Generic;
using System.Text;

namespace M05_UF3_P4_Design_Code
{
    public class Shopping_Cart
    {
        public List<Order_Item> order_items;
        
        public void add_item(Product product, int quantity)
        {

        }

        public void remove_item(Product product, int quantity) 
        {
        }

        public float total_price()
        { 
            return 0;
        }

        public void placeOrder()
        {

        }

      
    }
    
    public class Order : Shopping_Cart
    {
        public User user;
        public int invoice;
        public DateTime date;
        public int taxes;

        public float calculate_taxes()
        {
            return 0;
        }
    }

    public struct Order_Item
    {
        public Product product;
        public int quantity;
    }
}
