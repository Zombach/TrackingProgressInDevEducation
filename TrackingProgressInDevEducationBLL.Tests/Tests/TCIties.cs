﻿using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using TrackingProgressInDevEducationBLL.Models;
using TrackingProgressInDevEducationBLL.Models.NewStudent;
using TrackingProgressInDevEducationBLL.Tests.Expecteds;
using TrackingProgressInDevEducationDAL.Facades.Interfaces;
using TrackingProgressInDevEducationDAL.Models.Bases;

namespace TrackingProgressInDevEducationBLL.Tests.Tests
{
    public class TCIties : AbstractTest
    {
        public Mock<ICities> Mock;

        [SetUp]
        public void SetUp()
        {
            Mock = new Mock<ICities>();
        }

        [TestCaseSource(typeof(ECIties), nameof(ECIties.GetCities))]
        public void GetCities(EmptyQ query, List<City> expectedA, IEnumerable<GetCityA> expected)
        {
            var model = (City)BLLManager.CityQ.GetCities(query);
            Mock.Setup(mock => mock.GetCities()).Returns(expectedA);
            var actual = (List<GetCityA>)BLLManager.CityA.GetCities(expectedA);
            Assert.AreEqual(actual, expected);
        }
    }
}