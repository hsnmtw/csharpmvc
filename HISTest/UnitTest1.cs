using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DBManagerLibrary;
using ModelLibrary.Security;
using ControllerLibrary.Security;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using ControllerLibrary;
using ControllerLibrary.Utils;

namespace HISTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void Test_Encrypt_Decrypt()
        {
            string longtext = @"P@ssW0rd.!";

            string encrypted = CryptoFactory.Encrypt(longtext);
            string decrypted = CryptoFactory.Decrypt(encrypted);


            Assert.AreEqual(longtext, decrypted);
            Assert.AreEqual("{ENC}H4sIAAAAAAAEABOLkDea5vpjX1TJ5ZmaGe+y7k5nOT65U3MPAGy6HC8YAAAA", encrypted);

        }

        [TestMethod]
        public void Test_User_FetchAll_And_Delete()
        {
            UserController controller = new UserController();

            var all = controller.all();
            foreach (DataRow row in all.Rows)
            {
                controller.delete(new UserModel() { Id = int.Parse(row["Id"].ToString()) });
            }

            Assert.AreEqual(0, controller.all().Rows.Count);

            int cn1 = controller.all().Rows.Count;

            UserModel model = new UserModel();


            model.Full_Name = "Hussain3 Al-Mutawa";
            model.User_Name = "Hussain3";
            model.User_Password = "123";
            model.Profile_Name = "Admin";

            controller.insert(model);

            Assert.AreNotEqual(model.User_Password, "123");
            Assert.AreEqual(model.User_Password,new SimpleCrypto().encrypt("123"));
            Console.WriteLine(new SimpleCrypto().encrypt("123"));
            int cn2 = controller.all().Rows.Count;
            Assert.AreEqual(cn1 + 1, cn2);


        }
    }
}
