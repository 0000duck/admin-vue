﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_element.UI.Filters
{
    /// <summary>
    /// Description Attribute
    /// </summary>
    public class DescriptionAttribute : Attribute
    {
        public string Name
        {
            set;
            get;
        }
        public int No
        {
            set;
            get;
        }
    }
}