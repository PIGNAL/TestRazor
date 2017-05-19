using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestRazor.Helpers
{
    public static class CustomHelpers
    {
        public static IHtmlString LabelTest(this HtmlHelper htmlhelper)
        {
            return new HtmlString("<label>Test</label>");
        }
    }
}