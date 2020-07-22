using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laitkor_Task.Models
{
    public class DummyDb
    {
        static List<User> Users = new List<User>()
        {
           new User{ UserId="1",Name ="Test", Email="test@gmail.com",Address="Lucknow",Age=20, Job="test",UserName="testuser",Password="1234"},
           new User{ UserId="2",Name ="Test1", Email="test1@gmail.com",Address="lucknow",Age=21, Job="test1",UserName="testuser1",Password="12341"}
        };
        
        public static List<User> getUsers()
        {
            return Users;
        }
    }
}