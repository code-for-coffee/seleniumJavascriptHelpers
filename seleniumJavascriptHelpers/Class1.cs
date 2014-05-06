using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumJavascriptHelpers
{
    #region jQueryScriptHelper
    /// <summary>
    /// Uses jQuery scripts to manipulate the DOM of your website via Selenium.
    /// </summary>
    public virtual class jQueryScriptHelper
    {
        public static IJavaScriptExecutor Scripts(this IWebDriver driver)
        {
            return (IJavaScriptExecutor)driver;
        }
    }
    #endregion
    #region Private
    private class jQueryHeleprsPrivates() {
        private string setElementValue(string Selector) {
        }
        private string getElementValue(string Selector, string Value) {
        }
    }

    #endregion
}


