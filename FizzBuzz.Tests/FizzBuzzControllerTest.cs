using NUnit.Framework;
using FizzBuzz.Controllers;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;

namespace FizzBuzz.Tests
{
    public class FizzBuzzControllerTests
    {
        private Mock<IFizzBuzzFunction> _fizzBuzzFunction;
        private readonly List<string> _expectedList = new List<string> { "FizzBuzz", "Fizz", "Buzz" };

        [SetUp]
        public void Setup()
        {
            _fizzBuzzFunction = new Mock<IFizzBuzzFunction>();
        }

        [Test]
        public void GetFizzBuzz_WithValidInput_ReturnsOkStatusAndCorrectList()
        {
            // Arrange
            var inputList = new List<string> { "15","3","5" };
            _fizzBuzzFunction.Setup(a => a.GetFizzBuzz(inputList)).Returns(_expectedList);
            var fizzBuzzController = new FizzBuzzController(_fizzBuzzFunction.Object);

            // Act
            var result = fizzBuzzController.GetFizzBuzz(inputList) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(_expectedList, result.Value as List<string>);
        }
    }
}
