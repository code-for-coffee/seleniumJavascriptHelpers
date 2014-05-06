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
        public virtual bool GetElementValue(string Selector, IWebDriver Driver) {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            try {
                string title = (string)js.ExecuteScript(getElementValue(Selector));
            } catch (WebDriverException e) {
                Console.WriteLine("jQueryScriptHelper error: " + e);
                return false;
            }
            return true;
        }
        public virtual bool GetElementDataAttribute(string Selector, string DataAttribute, IWebDriver Driver) {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            try {
                string title = (string)js.ExecuteScript(getElementDataAttribute(Selector, DataAttribute));
            } catch (WebDriverException e) {
                Console.WriteLine("jQueryScriptHelper error: " + e);
                return false;
            }
            return true;
        }
        public virtual bool SetElementValue(string Selector, string Value, IWebDriver Driver) {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            try {
                string title = (string)js.ExecuteScript(getElementDataAttribute(Selector, Value));
            } catch (WebDriverException e) {
                Console.WriteLine("jQueryScriptHelper error: " + e);
                return false;
            }
            return true;
        }
        public virtual bool SetElementDataAttribute(string Selector, string DataAttribute, string Value, IWebDriver Driver) {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            try {
                string title = (string)js.ExecuteScript(setElementDataAttribute(Selector, DataAttribute, Value));
            } catch (WebDriverException e) {
                Console.WriteLine("jQueryScriptHelper error: " + e);
                return false;
            }
            return true;
        }

    #endregion

    #region Private Methods
    private string getElementValue(string Selector) {
        string src = "console.log('jQuery Injection: getElementValue [started]')";
        src += "$('" + Selector + "').val()";
        src += "console.log('jQuery Injection: getElementValue [completed]')";
        return src;
    }
    private string getElementDataAttribute(string Selector, string DataAttribute)
    {
        string src = "console.log('jQuery Injection: getElementDataAttribute [started]')";
        src += "$('" + Selector + "').data(" + DataAttribute + ")";
        src += "console.log('jQuery Injection: getElementDataAttribute [completed]')";
        return src;
    }
    private string setElementValue(string Selector, string Value)
    {
        string src = "console.log('jQuery Injection: setElementValue [started]')";
        src += "$('" + Selector + "').val(" + Value + ")";
        src += "console.log('jQuery Injection: setElementValue [completed]')";
        return src;
    }
    private string setElementDataAttribute(string Selector, string DataAttribute, string Value)
    {
        string src = "console.log('jQuery Injection: setElementDataAttribute [started]')";
        src += "$('" + Selector + "').data(" + DataAttribute + ", " + Value + ")";
        src += "console.log('jQuery Injection: setElementDataAttribute [completed]')";
        return src;
    }
    #endregion
    }
}


