using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusApplication.Entity;

namespace BusApplication.DAL
{
    public class BusRepository
    {
        static List<Customer> userList = new List<Customer>();

        static BusRepository()
        {
            //Customer customer = new Customer("Mohan","Male","mohan1319","mona@1319",8870662125,DateTime.Parse("13/11/1998"),true);
            //userList.Add(customer);
            //customer = new Customer("Gowtham", "Male", "gowtham", "gowthi", 7788445566, DateTime.Parse("16/9/1998"),false,);
            //userList.Add(customer);
        }

        public IEnumerable<Customer> UserDetailDisplay()
        {
            return userList;
        }
        public void AddUser(Customer customer)
        {
            userList.Add(customer);
        }
        public int Check(Customer customer)
        {
            int count = 0;
            foreach(Customer i in userList)
            {
                if(i.userId==customer.userId && i.userPassword==customer.userPassword)
                {
                    count = 1;
                    break;
                }
            }
            return count;
        }
        public static List<Bus> TestBusList()
        {
            BusContext busContext = new BusContext();
            return busContext.bus.ToList();
        }
    }
}
