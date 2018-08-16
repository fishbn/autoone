using NSelene;
using static NSelene.Selene;
using OpenQA.Selenium;

namespace AutoOneTest.Pages.SearchPage
{
    class SearchFilter
    {
        private readonly SeleneElement _firstRegistrationDateFrom = S(Selectors.Default.firstRegistrationDateFromSelector);
        private readonly SeleneElement _firstRegistrationDateFromDropdown = S(Selectors.Default.firstRegistrationDateFromDropdownSelector);
        private readonly SeleneCollection _firstRegistrationDateFromDropdownOptions = SS(Selectors.Default.firstRegistrationDateFromDropdownOptionsSelector);
        private readonly SeleneElement _sortDropdown = S(Selectors.Default.sortDropdownSelector);
        private readonly SeleneCollection _sortDropdownOptions = SS(Selectors.Default.sortDropdownOptionsSelector);

        public void SetRegistrationDateFrom(int year)
        {
            _firstRegistrationDateFrom.Click();
            _firstRegistrationDateFromDropdown.Click();

            foreach (var option in _firstRegistrationDateFromDropdownOptions)
                if(option.Text.Equals(year.ToString())) option.Click();
        }

        public void SortByPrice(bool sortType) // true as ASC, false as DESC
        {
            _sortDropdown.Click();

            foreach (var option in _sortDropdownOptions)
                if (option.Text.Equals("Höchster Preis")) option.Click();         
        }
    }
}
