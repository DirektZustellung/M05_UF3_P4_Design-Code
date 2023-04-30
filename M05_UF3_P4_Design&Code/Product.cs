using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace M05_UF3_P4_Design_Code
{
    public class Product
    {
        public int id;
        public string name; 
        public string brand;
        public List<string> imageURL;
        public string description;
        public float price;
        public float discount;
        private List<string> labels;
        private List<Rating> user_ratings;
        public Category high;
        public Category low;

        public List<Rating> Sort_Ratings()
        {
            return null;

        }

        public float Apply_discount()
        { 
            return 0; 
        }
    }
    public class Complex_Product : Product 
    {
        public Category medium;
    }

    public class Category
    {
        public string name;

        public void add_category(Category category) 
        {
        }
        public void remove_category(Category category) 
        {
        }
    }

}
