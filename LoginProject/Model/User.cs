using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginProject.Model
{
    internal class User
    {
        string _username;
        string _password;
        bool _isSignedIn;
        Product[] _products;

        public User(string username, string password)
        {
            UserName = username;
            Password = password;
            _products = new Product[0];

        }

        public string UserName { get => _username;
            set
            {
                value = value.Trim();
                if (CheckPassword(value))
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("wrong input");
                }
            }
        }
        public string Password { get => _password; set => _password = value; }

        public bool IsSignedIn { get => _isSignedIn; set => _isSignedIn = value; }

        public Product[] Products { get; set; }

        public bool CheckPassword(string password)
        {
            (bool IsDiggit, bool IsUpper, bool IsLowwer) res = (IsDigit(password), IsUpper(password), IsLower(password));

            if (res.IsDiggit && res.IsUpper && res.IsLowwer)
            {
                return true;
            }
            return false;
            
        }

        public void Login()
        {
            Console.WriteLine("write name");
            string name = Console.ReadLine();
            Console.WriteLine("write password");
            string password = Console.ReadLine();

            if (CheckPassword(password))
            {
                UserName = name;
                Password = password;
                IsSignedIn = true;
            }
            else
            {
                Console.WriteLine("wrong input");
            }


        }

        public void Add(Product product)
        {
            if (product != null)
            {
                Array.Resize(ref _products, _products.Length + 1);
                Products[Products.Length - 1] = product;
            }
            
        }

        private bool IsDigit(string password)
        {
            foreach (var item in password)
            {
                var res = char.IsDigit(item);
                if (res)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsLower(string password)
        {
            foreach (var item in password)
            {
                var res = char.IsLower(item);
                if (res)
                {
                    return true;
                }
            }

            return false;
        }

        private bool IsUpper(string password)
        {
            foreach (var item in password)
            {
                var res = char.IsUpper(item);
                if (res)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
