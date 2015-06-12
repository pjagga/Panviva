using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP_Automation.Environments
{
    public class TestEnvironment
    {

        public static TestEnvironment GetEnvironment()
        {
            switch (Properties.Settings.Default.Environment)
            {
                case EnvironmentType.QA_A:
                    return new TestEnvironment("https://qa-a-iis03/");
                case EnvironmentType.QA_B:
                    return new TestEnvironment("https://qa-b-all02/");
                default:
                    throw new ArgumentException("Invalid Environment Setting has been used");

            }
        }



        public string Url
        {
            get;
            private set;
        }
        public TestEnvironment(string URL)
        {
            this.Url = URL;
        }
    }
}
