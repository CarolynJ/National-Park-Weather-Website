﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capstone.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Capstone.Web.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void HomeController_IndexAction_ReturnIndexView()
        {
            //Arrange
          //  HomeController controller = new HomeController(IForecastDAL forcastDal, IParkDAL parkDal, ISurveyDAL surveyDal);

            //Act
           // ViewResult result = controller.ParkList() as ViewResult;

            //Assert
           // Assert.AreEqual("ParkList", result.ViewName);
        }
    }
}