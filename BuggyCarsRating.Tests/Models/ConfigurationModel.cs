﻿namespace BuggyCarsRating.Tests.Models
{
    public class ConfigurationModel
    {
        public string ApplicationBaseUrl { get; set; }
        public WebDriverConfigurationModel WebDriver{ get; set; }
    }

    public class WebDriverConfigurationModel
    {
        public bool IsHeadless { get; set; }
        public int ImplicitWaitInSeconds { get; set; }
    }
}
