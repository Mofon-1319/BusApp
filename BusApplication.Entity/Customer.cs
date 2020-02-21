using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace BusApplication.Entity
{
    public class Customer
    {
        public string userName { get; set; }

        public string userGender { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string userId { get; set; }

        [DataType(DataType.Password)]
        public string userPassword { get; set; }

        public long userPhone { get; set; }

        public DateTime dateOfBirth { get; set; }

        public bool isAdmin { get; set; }
        public Country country { get; set; }

        public enum Country
        {
            India = 1,
            America,
            Pakistan,
            Malaysia,
            Singapore
        }

        public Customer()
        {

        }
        public Customer(string userId, string password)
        {
            this.userId = userId;
            this.userPassword = password;
        }
        public Customer(string name, string sex, string userId, string password, long phone, DateTime date,bool isAdmin,Country country)
        {
            this.userName = name;
            userGender = sex;
            this.userId = userId;
            this.userPassword = password;
            this.userPhone = phone;
            dateOfBirth = date;
            this.isAdmin = isAdmin;
            this.country = country;
        }
    }
}
