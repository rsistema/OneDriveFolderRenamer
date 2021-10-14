using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace OneDrive_Folder_Rename
{
    public partial class Form1 : Form
    {
        #region -> Global Variables
        //Directory to find registries to find onedrive login sessions
        public const string PathInstances = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Desktop\NameSpace\";
        //Directory to create registries to replace the original name to an alias
        public const string PathAlias = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\CLSID\";
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbDefaultName.DataSource = GetOneDriveInstances();
            cbDefaultName.DisplayMember = "Value";
            cbDefaultName.ValueMember = "Key";
        }

        /// <summary>
        /// Method to find all onedrive instances and return them as DataSource to ComboBox
        /// </summary>
        /// <returns></returns>
        public List<RegViewModel> GetOneDriveInstances()
        {
            try
            {
                var regs = new List<RegViewModel>();

                foreach (var item in Registry.CurrentUser.OpenSubKey(PathInstances).GetSubKeyNames())
                {
                    var value = Registry.CurrentUser.OpenSubKey(PathInstances + item).GetValue("");

                    if (value.ToString().ToLower().Contains("onedrive"))
                    {
                        regs.Add(new RegViewModel()
                        {
                            Key = item.ToString(),
                            Path = PathInstances.ToString(),
                            Value = value.ToString()
                        });
                    }
                }

                return regs;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void GetOneDriveAlias(RegViewModel selectedRegistry)
        {
            try
            {
                var regs = new List<RegViewModel>();

                var checkKey = Registry.CurrentUser.OpenSubKey(PathAlias + selectedRegistry.Key)?.GetValue("");

                if (checkKey == null)
                {
                    var newKey = Registry.CurrentUser.CreateSubKey(PathAlias + selectedRegistry.Key);
                    newKey.SetValue(selectedRegistry.Name, selectedRegistry.Value);
                    newKey.Close();

                    checkKey = Registry.CurrentUser.OpenSubKey(PathAlias + selectedRegistry.Key).GetValue("");
                }

                tbAliasName.Text = checkKey.ToString();
            }
            catch (Exception e)
            {
                
            }
        }

        private void cbDefaultName_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOneDriveAlias((RegViewModel)cbDefaultName.SelectedItem);
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            var success = UpdatedAliasName((RegViewModel)cbDefaultName.SelectedItem, tbAliasName.Text);

            string message = (success ? "Action completed successfully, restart explorer to confirm changes!" : "An error occured, try again...");
            string title = (success ? "Success" : "Fail");
            MessageBox.Show(message, title, MessageBoxButtons.OK);


        }

        /// <summary>
        /// Method to update the registry with the new alias name, return true/false
        /// </summary>
        /// <param name="selectedRegistry"></param>
        /// <param name="newAliasName"></param>
        /// <returns></returns>
        private bool UpdatedAliasName(RegViewModel selectedRegistry, string newAliasName)
        {
            try
            {
                var reg = Registry.CurrentUser.OpenSubKey(PathAlias + selectedRegistry.Key, true);
                reg.SetValue(selectedRegistry.Name, newAliasName);
                reg.Close();

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
