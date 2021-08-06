using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProductReviewManagement;
using System.Collections.Generic;

namespace ReviewValidation
{
    [TestClass]
    public class UnitTest1
    {
        List<ProductReview> productList;
        [TestInitialize]
        public void SetUp()
        {
            productList = new List<ProductReview>();
        }
        /// <summary>
        /// UC1--->Adding a Productreview details in list and returns the count
        /// </summary>
        [TestMethod]
        public void TestMethodForAddingDetailsInList()
        {
            int expected = 25;
            int actual = ProductReviewManager.AddingProductReview(productList);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC2--->Retrieve Top Three Records Whose Rating is High
        /// </summary>
        [TestMethod]
        public void TestMethodForRetrieveTopThreeRecord()
        {
            int expected = 3;

            var actual = ProductReviewManager.RetrieveTopThreeRating(productList);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// UC3-->Retrieve  records from list based on productid and rating > 3 
        /// </summary>
        [TestMethod]
        public void TestMethodForRetrieveRecordsBasedOnRatingAndProductId()
        {
            int[] expected = { 1, 1, 4, 9, 9, 1, 4 };
            var actual = ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productList);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
