﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Tests
{
    [TestClass()]
    public class WorkerSendTests
    {
        [TestMethod()]
        public void button_ClickTest()
        {
            var report = new DBConnect();         
            var expected = "true";
            bool returned;
            returned = report.OpenConnection();
            Assert.AreEqual(expected, returned);

        }
    }
}