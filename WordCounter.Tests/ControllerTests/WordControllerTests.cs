using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordControllerTest
    {
        [TestMethod]
        public void Index_ReturnsCorrectView_True()
        {
            WordController controller = new WordController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectView_True()
        {
            WordController controller = new WordController();
            ActionResult NewView = controller.New();
            Assert.IsInstanceOfType(NewView, typeof(ViewResult));
        }

        [TestMethod]
        public void Create_ReturnsCorrectActionType_RedirectToActionResult()
        {
            //Arrange
            WordController controller = new WordController();

            //Act
            IActionResult view = controller.Create("word", "word in a sentence");

            //Assert
            Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
        }

        [TestMethod]
        public void Create_RedirectsToCorrectAction_Index()
        {
            //Arrange
            WordController controller = new WordController();
            RedirectToActionResult actionResult = controller.Create("word", "word in a sentence") as RedirectToActionResult;

            //Act
            string result = actionResult.ActionName;

            //Assert
            Assert.AreEqual(result, "Index");
        }
    }

}