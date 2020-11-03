using System;
using System.Collections.Generic;
using Cafe_ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cafe_UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestClass]
        public class Menu_Repo_Tests
        {

            [TestMethod]
            public void CreateNewItem_ShouldGetCorrectBoolean()
            {
                Menu MenuItem = new Menu();
                Menu_Repo repo = new Menu_Repo();

                bool addResult = repo.CreateNewMenuItem(MenuItem);

                Assert.IsTrue(addResult);
            }

            [TestMethod]
            public void ShowEntireMenu_ShouldBeRight()
            {
                Menu MenuItem = new Menu();
                Menu_Repo repo = new Menu_Repo();

                List<Menu> contents = repo.GetMenu();

                bool repoContents = contents.Contains(MenuItem);
            
                Assert.IsTrue(repoContents);
            }


            [TestMethod]
            public void DeleteMenuItem_ShouldReturnTrue()
            {
                Menu_Repo repo = new Menu_Repo();
                Menu MenuItem = new Menu(1, "Potato Bacon Cheddar Soup","Cheesy potatoes and bacon make soupy goodness","Potatoes, Cheese, Bacon, Soup",5.99m);
                repo.CreateNewMenuItem(MenuItem);

                Menu oldMenuItem = repo.GetMenuByName("Potato Bacon Cheddar Soup");

                bool deleteResult = repo.DeleteMenuItem(oldMenuItem);

                Assert.IsTrue(deleteResult);
            }
        }
    }
}
