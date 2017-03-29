using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using System.Data.SqlClient;

namespace CodedUISessionManagement
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void CodedUIUpdateSessionTest()
        {
            //Perform automated test
            this.UIMap.RecordedMethodUpdate();

            string sID = UIMap.UIUpdateSessionWindow.UITxtStaffIDWindow.UITxtStaffIDEdit.Text;
            string sesID = UIMap.UIUpdateSessionWindow.UITxtSearchBoxWindow.UITxtSearchBoxEdit.Text;
            string d = UIMap.UIUpdateSessionWindow.UIDateTimePicker1Window.UIDateTimePicker1DateTimePicker.ToString();
            string sTime = UIMap.UIUpdateSessionWindow.UIComboBoxEx1Window.UIComboBoxEx1ComboBox.ToString();
            string eTime = UIMap.UIUpdateSessionWindow.UIComboBoxEx2Window.UIComboBoxEx2ComboBox.ToString();

            this.UIMap.RecordedMethodSubmit();

            //Validation that the data is there
            Verify verify = new Verify();
            bool i = verify.getSession(sesID, sID, d, sTime, eTime);
            if(i == false)
            {
                Assert.Fail();
            }
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
