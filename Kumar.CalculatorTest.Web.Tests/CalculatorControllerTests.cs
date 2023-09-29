using Kumar.CalculatorTest.Web.Controllers;
using Kumar.CalculatorTest.Web.Model;
using Kumar.CalculatorTest.Web.Repository;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Kumar.CalculatorTest.Web.Tests
{
    [TestFixture]
    public class CalculatorControllerTests
    {
        private CalculatorController _controller;

        [SetUp]
        public void Setup()
        {
            var repository = new CalculatorRepository();
            _controller = new CalculatorController(repository);
        }

        [Test]
        public void Add_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var requestModel = new CalculationRequestModel { Number1 = 5, Number2 = 3 };

            // Act
            var result = _controller.Add(requestModel) as ActionResult<int>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.IsInstanceOf<int>(okResult.Value);
            Assert.AreEqual(8, (int)okResult.Value);
        }

        [Test]
        public void Subtract_ValidInput_ReturnsOkResult()
        {
            // Arrange
            var requestModel = new CalculationRequestModel { Number1 = 10, Number2 = 5 };

            // Act
            var result = _controller.Subtract(requestModel) as ActionResult<int>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<OkObjectResult>(result.Result);
            var okResult = result.Result as OkObjectResult;
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.IsInstanceOf<int>(okResult.Value);
            Assert.AreEqual(5, (int)okResult.Value);
        }

        [Test]
        public void Add_InvalidInput_ReturnsBadRequest()
        {
            // Arrange
            var requestModel = new CalculationRequestModel { Number1 = 5, Number2 = int.MaxValue };

            // Act
            var result = _controller.Add(requestModel) as ActionResult<int>;

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOf<BadRequestObjectResult>(result.Result);
            var badRequestResult = result.Result as BadRequestObjectResult;
            Assert.AreEqual(400, badRequestResult.StatusCode);
        }

        }
}
