using NUnit.Framework;
using FizzBuzz.Controllers;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
using System;

namespace FizzBuzz.Tests
{
    public class FizzBuzzControllerTests
    {
        private Mock<IFizzBuzzFunction> _fizzBuzzFunction;
        private readonly List<string> _expectedList = new List<string> ();

        [SetUp]
        public void Setup()
        {
            _fizzBuzzFunction = new Mock<IFizzBuzzFunction>();
        }

        [Test]
        public void Test1()
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

        [Test]
        public void Test2()
        {
            // Arrange
            var inputList = new List<string> { "@","","51", "39", "45", "-" };
            _fizzBuzzFunction.Setup(a => a.GetFizzBuzz(inputList)).Returns(_expectedList);
            foreach (var value in _expectedList)
                Console.WriteLine(value);
            var fizzBuzzController = new FizzBuzzController(_fizzBuzzFunction.Object);

            // Act
            var result = fizzBuzzController.GetFizzBuzz(inputList) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(_expectedList, result.Value as List<string>);
        }

        [Test]
        public void Test3()
        {
            // Arrange
            var inputList = new List<string> { "@","","invalid", "string", "150", "-15" };
            _fizzBuzzFunction.Setup(a => a.GetFizzBuzz(inputList)).Returns(_expectedList);
            foreach (var value in _expectedList)
                Console.WriteLine(value);
            var fizzBuzzController = new FizzBuzzController(_fizzBuzzFunction.Object);

            // Act
            var result = fizzBuzzController.GetFizzBuzz(inputList) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(_expectedList, result.Value as List<string>);
        }

        [Test]
        public void Test4()
        {
            // Arrange
            var inputList = new List<string> { "34",""," ", "OMG", "123", "Z015X" };
            _fizzBuzzFunction.Setup(a => a.GetFizzBuzz(inputList)).Returns(_expectedList);
            foreach (var value in _expectedList)
                Console.WriteLine(value);
            var fizzBuzzController = new FizzBuzzController(_fizzBuzzFunction.Object);

            // Act
            var result = fizzBuzzController.GetFizzBuzz(inputList) as OkObjectResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(200, result.StatusCode);
            Assert.AreEqual(_expectedList, result.Value as List<string>);
        }

        [Test]
        public void Test5()
        {
            // Arrange
            var inputList = new List<string> { "###","","3e9", "099", "r15", "2^2" };
            _fizzBuzzFunction.Setup(a => a.GetFizzBuzz(inputList)).Returns(_expectedList);
            foreach (var value in _expectedList)
                Console.WriteLine(value);
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
