using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountControllerTest
    {

        [TestMethod]
        public void Index_HasCorrectModelType_Word()
        {

            //Arrange
            Word newNew = new Word("this is a sentence", "word", 0);
            WordController controller = new WordController();
            ViewResult indexView = controller.Index(newNew) as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsInstanceOfType(result, typeof(Word));
        }

        [TestMethod]
        public void CreateForm_ReturnsCorrectView_True()
        {
            //Arrange
            Word newNew = new Word("this is a sentence", "word", 0);
            WordController controller = new WordController();

            //Act
            ActionResult formView = controller.CreateForm();

            //Assert
            Assert.IsInstanceOfType(formView, typeof(ViewResult));
        }


    }
}