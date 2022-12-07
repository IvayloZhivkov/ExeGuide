using ExeGuide.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ExeGuide.Tests
{
    public class Tests
    {
        [TestClass]
        public class ExerciseControllerTests
        {
            [TestMethod]
            public void TestDetailsView()
            {
                var controller = new ExerciseController();
                var result = controller.Details(2) as ViewResult;
                Assert.AreEqual("Details", result.ViewName);

            }
        }
    }
}