using System;
using AutoOneTest.Pages.SearchPage;
using NUnit.Framework;

namespace AutoOneTest.Tests
{
    class SearchTest : BaseTest
    {   
        private static readonly SearchFilter SearchFilter = new SearchFilter();
        private static readonly SearchResults SearchResults = new SearchResults();

        [TestCase(2015, false)] //true as ASC, false as DESC
        public void Search(int registrationDateFrom, bool sortType)
        {
            SearchFilter.SetRegistrationDateFrom(registrationDateFrom);
            SearchFilter.SortByPrice(sortType);

            Assert.True(SearchResults.VerifyFilterByFirstRegistrationDateFrom(registrationDateFrom));
            Assert.True(SearchResults.VerifySortByPrice(sortType));
        }
    }

    
    
}
