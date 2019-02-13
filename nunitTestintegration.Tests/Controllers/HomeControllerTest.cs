using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using MvcApplication1;
using MvcApplication1.Controllers;
using NUnit.Framework;

namespace nunitTestintegration.Tests.Controllers
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void IndexActionReturnsIndexView()
        {
            string expected = "Index";
            HomeController controller = new HomeController();

            var result = controller.Index() as ViewResult;

            Assert.AreEqual(expected, result.ViewName);
        }

      
    }
}
