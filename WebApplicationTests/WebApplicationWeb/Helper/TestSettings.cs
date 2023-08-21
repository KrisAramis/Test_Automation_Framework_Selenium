﻿using WebApplicationCore.Enums;
using NUnit.Framework;

namespace WebApplicationWeb.Helper
{
    public static partial class TestSettings
    {
        public static TestContext TestContext { get; set; }

        #region RunSettingsMethods
        
        public static string LogsPath => Path.Combine(TestContext.TestDirectory, @TestContext.Parameters.Get("LogsPath").ToString());

        public static TimeSpan WebDriverTimeOut => TimeSpan.FromSeconds(int.Parse(TestContext.Parameters.Get("WebDriverTimeOut").ToString()));

        public static string DefaultTimeOut => TestContext.Parameters.Get("WaitElementTimeOut").ToString();

        public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();

        #endregion

    }
}
