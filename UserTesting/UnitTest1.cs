using System;
using System.Web;
using System.Web.Mvc;
using Laitkor_Task.Controllers;
using Laitkor_Task.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UserTesting
{
    [TestClass]
    public class UnitTest1
    {
        UserController con = new UserController();

        //This is positive testcase of Login where we pass the valid credentials 
        [TestMethod]
        public void LoginSuccessfull()
        {
            User _user = new User();
            _user.UserName = "testuser";
            _user.Password = "1234";
            var result=con.Login(_user) as RedirectToRouteResult;
            Assert.AreEqual("Dashboard",result.RouteValues["action"]);
        }


        // Negative testcase of Login where we pass the Invalid credentials 
        [TestMethod]
        public void LoginFailure()
        {
            User _user = new User();
            _user.UserName = "test";
            _user.Password = "123487687";
            var result = con.Login(_user) as RedirectToRouteResult;
            Assert.AreEqual("Login", result.RouteValues["action"]);
        }
    }
}
