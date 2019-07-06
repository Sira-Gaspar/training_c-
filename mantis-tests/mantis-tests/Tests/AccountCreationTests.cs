using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.IO;
using TestContext = NUnit.Framework.TestContext;

namespace mantis_tests
{

    [TestFixture]
    public class AccountCreationTests : TestBase
    {
        [OneTimeSetUp]
        public void SetUpConfig()
        {
            app.Ftp.BackupFile("/config_defaults_inc.php");
            using (Stream localFile = File.Open
                (TestContext.CurrentContext.TestDirectory + @"\config_defaults_inc.php", 
                FileMode.Open))
            {
                app.Ftp.UploadFile("/config_defaults_inc.php", localFile);
            }
        }

        [Test]
        public void TestAccountRegistration()
        {
            AccountData account = new AccountData()
            {
                Name = "testuser",
                Password = "password",
                Email = "testuser@localhost.localdomain"
            };

            app.Registration.Register(account);
        }

        [OneTimeTearDown]
        public void RestoreConfig()
        {
            app.Ftp.RestoreBackupFile("/config_defaults_inc.php");
        }
    }
}
