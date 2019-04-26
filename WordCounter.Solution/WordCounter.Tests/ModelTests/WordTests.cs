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
             Word newWord = new Word("test sentence", "testWord", 0);
             Assert.AreEqual(typeof(Word), newWord.GetType());
         }

        [TestMethod]
        public void SentenceGetter_ChecksGetters_Sentence()
        {
            string sent = "test sentence";
            Word newWord = new Word(sent, "placeHold", 0);
            Assert.AreEqual(sent, newWord.GetSent());
        }


        [TestMethod]
        public void WordGetter_ChecksGetters_Word()
        {
            string testWord = "testWord";
            Word newWord = new Word("place Hold", testWord, 0);
            Assert.AreEqual(testWord, newWord.GetWord());
        }

        [TestMethod]
        public void WordFinder_FindsWords_3()
        {
            string testWord = "cat";
            string testSent = "The cat cat in the cat cathederal";
            Word newWord = new Word(testSent, testWord, 0);
            Assert.AreEqual(3, newWord.WordFinder());
        }

        [TestMethod]
        public void CheckWord_ChecksForSpace_false()
        {
            string testWord = "cat hat";
            string testSent = "The cat cat in the cat cathederal";
            Word newWord = new Word(testSent, testWord, 0);
            Assert.AreEqual(false, newWord.CheckWord());
        }
        [TestMethod]
        public void CheckWord_ChecksForSpace_true()
        {
            string testWord = "cathat";
            string testSent = "The cat cat in the cat cathederal";
            Word newWord = new Word(testSent, testWord, 0);
            Assert.AreEqual(true, newWord.CheckWord());
        }
    }
 }