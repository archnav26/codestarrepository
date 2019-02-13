using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NUnit.Framework;

namespace MVCUnittest
{

    [TestFixture]
    public class HomeControllerTest
    {

        [Test]
        public void IndexActionReturnsIndexView()
        {
            string expected = "Index";
            MVCUnittest.Controllers.HomeController controller = new MVCUnittest.Controllers.HomeController();

            var result = controller.Index() as ViewResult;

            Assert.AreEqual(expected, result.ViewName);
        }

    }
}