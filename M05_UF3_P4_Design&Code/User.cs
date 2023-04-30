using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace M05_UF3_P4_Design_Code
{
    public class User
    {
        public string name;
        public string surname;
        protected string email;
        private string password;
        public int telephone;
        public string DNI;
        public Address billing_address;
        public List<AddressFamily> shipping_address;
        public List<Product> wish_list;
        public Shopping_Cart cart;

        public bool check_DNI(string dni)
        {
            return true;
        }

        public void add_to_wish_list(Product product) 
        {
        }

        public void add_to_shipping_address(Address address)
        {

        }

        public void fortgot_password()
        {

        }

        public Rating Create_Rating(Product product)
        {
            return null;
        }
    }

    public struct Address
    {
        public string street;
        public int number;
        public int floor;
        public int door;
        public int postal_code;
        public string city;
        public string country;
    }
}
