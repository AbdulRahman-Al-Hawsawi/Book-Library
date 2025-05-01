using BookLibrary_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library.GlobalClasses
{
   public class clsGlobal
    {
        public static clsUser CurrentUser;

       
        public  enum enPermissions
        {
            Full = -1/* <- Absolute authority over the system*/, AddBooks = 1, UpdateBooks = 2, DeleteBooks = 4,
            ReadUsers = 8, AddUsers = 16, UpdateUsers = 32, DeleteUsers = 64
        };
        
        public static bool CheckIsUserHaveAccessPermissionFor(enPermissions Permission)
        {

            if ((enPermissions)CurrentUser.Permissions == enPermissions.Full)
                return true;

            if ((Permission & (enPermissions)CurrentUser.Permissions) == Permission)
                return true;
            else
                return false;
        }

        public static bool CheckIsUserHaveAccessPermissionFor(clsUser User,enPermissions Permission)
        {

            if ((enPermissions)User.Permissions == enPermissions.Full)
                return true;

            if ((Permission & (enPermissions)User.Permissions) == Permission)
                return true;
            else
                return false;
        }
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LogedInUserInfo";
            string ValueName = "UsernameAndPassword";

            try
            {
                if (Username == "")
                {
                    string keyPathToDelete = @"SOFTWARE\LogedInUserInfo";
                    /// delete data from registry
                    using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                    {
                        using (RegistryKey key = baseKey.OpenSubKey(keyPathToDelete, true))
                        {
                            if (key != null)
                            {
                                key.DeleteValue(ValueName);
                                return true;
                            }
                        }
                    }
                }

                string DataToSave = Username + "#//#" + Password;
                Registry.SetValue(keyPath, ValueName, clsDataHelper.Encrypt(DataToSave), RegistryValueKind.String);
                return true;

            }
            catch (Exception e)
            {
                //MessageBox.Show("An error occured {0}", e.Message);
                return false;

            }

        }

        public static bool GetStoredCredintial(ref string Username, ref string Password)
        {
            string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\LogedInUserInfo";
            string ValueName = "UsernameAndPassword";

            //this will get the stored username and password and will return true if found and false if not found.
            try
            {

                string LoginInfo = Registry.GetValue(keyPath, ValueName, null) as string;

                string[] Line = clsDataHelper.Decrypt(LoginInfo).Split(new string[] { "#//#" }, StringSplitOptions.None);

                if (Line[0] == "")
                    return false;

                Username = Line[0];
                Password = Line[1];
                return true;

            }
            catch (Exception e)
            {
                //MessageBox.Show("An error occured {0}", e.Message);
                return false;
            }
        }

        public static void SaveToEventLog(string EventMessage, EventLogEntryType eventLogEntryType, string SourceApp = "BookLibrary_App")
        {
            try
            {             
                if (!EventLog.SourceExists(SourceApp))
                    EventLog.CreateEventSource(SourceApp, "Application");

                EventLog.WriteEntry(SourceApp, EventMessage, eventLogEntryType);
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(SourceApp, "Exception in LogException method", EventLogEntryType.Error);
            }

        }

        public static DataTable GetAllApplicationEventLogs(string sourceName = "BookLibrary_App")
        {
            DataTable MySourceEvent = new DataTable();
            MySourceEvent.Columns.Add("Entry Type");
            MySourceEvent.Columns.Add("Date and Time");
            //MySourceEvent.Columns.Add("Source");
            MySourceEvent.Columns.Add("Message");

            try
            {
                EventLog applicationLog = new EventLog("Application");
              
                foreach (EventLogEntry entry in applicationLog.Entries)
                {                
                    if (entry.Source.Equals(sourceName, StringComparison.OrdinalIgnoreCase))
                    {
                        MySourceEvent.Rows.Add(
                     entry.EntryType.ToString(),
                     entry.TimeWritten,                    
                     entry.Message
                       );                       
                    }
                }
            }
            catch (Exception ex)
            {
                SaveToEventLog(ex.Message, EventLogEntryType.Error);
            }
            return MySourceEvent;
        }




    }
}

