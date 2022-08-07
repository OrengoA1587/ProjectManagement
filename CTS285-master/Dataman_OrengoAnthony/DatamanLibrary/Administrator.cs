using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public class Administrator
    {
        #region Player Class
        //Fields
        private string _password;
        private bool _adminLock;

        //Default constructors
        public Administrator()
        {
            Password = "";
            AdminLock = false; 
        }
        //Custom Constructors
        public Administrator(string password,bool adminLock)
        {
           Password = password;
            AdminLock = adminLock;
        }
        //Properties
        public string Password
        {
            get { return _password; }
            set { _password = value; }

        }
        public bool AdminLock
        {
            get { return _adminLock; }
            set { _adminLock = value; }
        }
        #endregion
    }
}