 using Microsoft.VisualStudio.TestTools.UnitTesting;
 using WordCounter;
 using System;
 using System.Collections.Generic;

 namespace WordCounter.Tests 
 {

   [TestClass]
   public class WordTest
   {

     [TestMethod]
         public void WordConstructor_CreatesInstanceOfWord_Word()
         {
             Word newWord = new Word("test sentence", "testWord");
             Assert.AreEqual(typeof(Word), newWord.GetType());
         }

        [TestMethod]
        public void SentenceGetter_ChecksGetters_Sentence()
        {
            string sent = "test sentence";
            Word newWord = new Word(sent, "placeHold");
            Assert.AreEqual(sent, newWord.GetSent());
        }


        [TestMethod]
        public void WordGetter_ChecksGetters_Word()
        {
            string testWord = "testWord";
            Word newWord = new Word("place Hold", testWord);
            Assert.AreEqual(testWord, newWord.GetWord());
        }

        [TestMethod]
        public void WordFinder_FindsWords_3()
        {
            string testWord = "cat";
            string testSent = "The cat cat in the cat cathederal";
            Word newWord = new Word(testSent, testWord);
            Assert.AreEqual(3, newWord.WordFinder());
        }
    }
 }