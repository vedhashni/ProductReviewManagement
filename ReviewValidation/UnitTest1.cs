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

        /// <summary>
        /// UC4-->Retrived the count of productId
        /// </summary>
        [TestMethod]
        public void TestMethodForCountingProductId()
        {
            string expected = "1 3 2 4 3 4 4 2 9 2 5 3 7 1 10 1 12 1 14 1 18 1 13 1 19 1 ";
            string actual = ProductReviewManager.CountingProductId(productList);
            Assert.AreEqual(expected, actual);

        }
    }
}
