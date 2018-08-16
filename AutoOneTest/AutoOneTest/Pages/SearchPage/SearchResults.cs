using System;
using System.Text.RegularExpressions;
using NSelene;
using static NSelene.Selene;
using OpenQA.Selenium;

namespace AutoOneTest.Pages.SearchPage
{
    class SearchResults
    {
        private readonly SeleneCollection _totalPrices = SS(Selectors.Default.totalPricesSelector);
        private readonly SeleneCollection _firstRegistrationDates = SS(Selectors.Default.firstRegistrationDatesSelector);

        public bool VerifyFilterByFirstRegistrationDateFrom(int _year)
        {
            foreach (var date in _firstRegistrationDates)
            {
                try
                {
                    int year = Int32.Parse(Regex.Match(date.Text, @"\d+").Value);
                    if (year < _year && year > DateTime.Now.Year)
                        return false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } 
            return true;
        }

        public bool VerifySortByPrice(bool _sortType)
        {
            int previousPrice = _sortType ? 0 : 100000000;

            foreach (var totalPrice in _totalPrices)
            {
                try
                {
                    int price = Int32.Parse(Regex.Match(totalPrice.Text.Replace(".", ""), @"\d+").Value);

                    if(_sortType)
                        if (price < previousPrice) return false;
                    if(!_sortType)
                        if (price > previousPrice) return false;

                    previousPrice = price;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return true;
        }

    }
}
