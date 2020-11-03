using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe_ClassLibrary
{
    public class Menu_Repo
    {

        private List<Menu> _menu = new List<Menu>();

        public bool CreateNewMenuItem(Menu newMenu)
        {
            int startingCount = _menu.Count;
            _menu.Add(newMenu);
           bool wasAdded = (_menu.Count > startingCount) ? true : false;
           return wasAdded;
        }
        
        public List<Menu> GetMenu()
        {
            return _menu;
        }

        public bool DeleteMenuItem(Menu existingMenu)
        {
            bool deleteResult = _menu.Remove(existingMenu);
            return deleteResult;
        }

        //public StreamingContent GetContentByTitle(string title)
        //{
        //    foreach (StreamingContent content in _contentDirectory)
        //    {
        //        if (content.Title.ToLower() == title.ToLower())
        //        {
        //            return content;
        //        }
        //    }
        //    return null;
        //}


        // new up list of menu

        //Add/Create

        //Read//Return

        //Delete//Remove
        //private List<Menu> _menu = new List<Menu>();

        //public bool AddMenu(Menu newMenu)
        //{
        //    int startingCount = _menu.Count;
        //    _menu.Add(newMenu);
        //    bool wasAdded = (_menu.Count > startingCount) ? true : false;
        //    return wasAdded;
        //}
        ////READ ALL   
        //GetContents
        //public List<Menu> GetMenu()
        //{
        //    return _menu;
        //}
        ////READ A SINGLE OBJECT
        //public Menu GetMenuByName(string name)
        //{
        //    //Goes through each object in the list
        //    foreach (Menu menu in _menu)
        //    {
        //        //Checks for a name match with the parameter entered
        //        if (menu.MealName == name)
        //        {
        //            //if the name is found,here is where it is returned.
        //            return menu;
        //        }
        //    }
        //    return null;


        //update
        void UpdateExistingContent()
        {

        }
        //}
        ////Update an existing Object
        //public bool UpdateExistingMenu(string originalName, Menu newObject)
        //{
        //    return true;
        //}
        //public bool DeleteExistingMenu(Menu existingmenu)
        //{
        //    //Sets deleteResult to True if the object is removed.
        //    bool deleteResult = _menu.Remove(existingmenu);
        //    return deleteResult;
        //}
        ////A method for printing entire menu

    }
}
