﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    public class TestBase
    {
        protected ApplicationManager app;

        [SetUp]
        public void SetupTests()
        {
            app = new ApplicationManager();
        }                     
       
        [TearDown]
        public void TeardownTest()
        {
            app.Stop();         
           
        }          
    }
}
