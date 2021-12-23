namespace NUnitFramework.Pages.Forms.PracticeFormElements
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;

    public class ThanksForSubmittingFormElement
    {
        private IWebElement ThanksForSubmittingForm { get; set; }

        private IList<IWebElement> TableRows => ThanksForSubmittingForm.FindElements(By.XPath("//tbody/tr"));

        public ThanksForSubmittingFormElement(IWebDriver driver) =>
            ThanksForSubmittingForm = driver.FindElement(By.CssSelector(".modal-content"));

        public string GetRowValueByLable(string rowLable)
        {
            string rowValue = null;

            foreach (var row in TableRows)
            {
                var lable = row.FindElement(By.XPath("./td[1]"));

                if (lable.Text.Trim().Equals(rowLable, StringComparison.OrdinalIgnoreCase))
                {
                    rowValue = row.FindElement(By.XPath("./td[2]")).Text;
                }
            }

            return rowValue;
        }
    }
}
