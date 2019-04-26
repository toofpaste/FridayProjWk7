 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using WordCounter;
 using System;
 using System.Collections.Generic;

 namespace WordCounter.Tests 
 {

   [TestClass]
   public class WordTest : IDisposable
   {

     public void Dispose()
         {
             Word.ClearAll();
         }
     [TestMethod]
         public void WordConstructor_CreatesInstanceOfWord_Word()
         {
             Word newWord = new Word("test");
             Assert.AreEqual(typeof(Word), newWord.GetType());
         }
   }
 }