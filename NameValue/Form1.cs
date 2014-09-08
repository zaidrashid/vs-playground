// Name Value test program
// Zaid Rashid
// 8/7/2014
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;
using NameValuePairTestProgram.Classes;

namespace NameValuePairTestProgram
{
    public partial class Form1 : Form
    {

        List<KeyValuePair<string, string>> nameValueList = new List<KeyValuePair<string, string>>();

        public Form1()
        {
            InitializeComponent();
            InitializeAcceptButton();
        }
        
        #region UI Handlers
        private void InitializeAcceptButton()
        {
            this.AcceptButton = save_btn;
            save_btn.Enabled = false;
        }
        private void UpdateListBox(List<KeyValuePair<string,string>> _nameValuePair = null)
        {
            if (_nameValuePair != null)
            {
                nameValueList = _nameValuePair;
            }

            key_value_lstbx.Items.Clear();
            if (nameValueList.Count() > 0)
            {
                foreach (var pair in nameValueList)
                {
                    string readablePair = string.Empty;
                    using (NameValue nv = new NameValue())
                    {
                        readablePair = nv.ConvertToReadableString(pair);
                    }
                    key_value_lstbx.Items.Add(readablePair);
                }
            }
        }
        private void ClearTextBox()
        {
            insert_txtbx.Clear();
            insert_txtbx.Focus();
        }
        #endregion

        #region Button Handlers
        private void save_btn_Click(object sender, EventArgs e)
        {
            string insertValue = insert_txtbx.Text;
            var nameValue = new KeyValuePair<string, string>();

            using (NameValue nv = new NameValue())
            {
                nameValue = nv.ConvertToKeyValuePair(insertValue);
            }

            if (!nameValue.Equals(new KeyValuePair<string,string>()))
            {
                nameValueList.Add(nameValue);
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Invalid value entered. Please enter an alpha-numeric [0-9 or a-z] value with the format \"<name>=<value>\"", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            ClearTextBox();
        }
        private void sort_val_btn_Click(object sender, EventArgs e)
        {
            key_value_lstbx.Items.Clear();
            if (nameValueList.Count > 0)
            {
                nameValueList.Sort(SortValue);
                UpdateListBox(nameValueList);
            }
            else
            {
                MessageBox.Show("List Box is empty.", "Sort by Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void sort_name_btn_Click(object sender, EventArgs e)
        {
            key_value_lstbx.Items.Clear();
            if (nameValueList.Count > 0)
            {
                nameValueList.Sort(SortKey);
                UpdateListBox(nameValueList);
            }
            else
            {
                MessageBox.Show("List Box is empty.", "Sort by Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            var selectedItems = key_value_lstbx.SelectedItems;
            if (selectedItems.Count > 0)
            {
                var nameValue = new KeyValuePair<string, string>();
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    using (NameValue nv = new NameValue())
                    {
                        nameValue = nv.ConvertToKeyValuePair(selectedItems[i].ToString());
                    }

                    nameValueList.Remove(nameValue);
                }
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("No items being selected.", "Delete", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void save_xml_btn_Click(object sender, EventArgs e)
        {
            if (nameValueList.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XElement xe = new XElement("NameValue",
                                        from nameValue in nameValueList
                                        select new XElement(nameValue.Key, nameValue.Value)
                                    );

                        XmlSerializer writer = new XmlSerializer(typeof(XElement));

                        System.IO.StreamWriter file = new System.IO.StreamWriter(@saveFileDialog.FileName);
                        writer.Serialize(file, xe);
                        file.Close();
                        MessageBox.Show("File saved successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else 
            {
                MessageBox.Show("No data to be saved.", "Save as XML", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region TextBox Handler
        private void insert_txtbx_TextChange(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(insert_txtbx.Text.Trim()))
            {
                save_btn.Enabled = false;
            }
            else
            {
                save_btn.Enabled = true;
            }
        }
        private void insert_txtbx_Click(object sender, EventArgs e)
        {
            if (insert_txtbx.Text == "Enter your \"name=value\" pair here...")
            {
                ClearTextBox();
            }
        }
        #endregion

        #region KeyValueList Sorting Handler
        static int SortKey(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
        {
            return a.Key.CompareTo(b.Key);
        }
        static int SortValue(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
        {
            return a.Value.CompareTo(b.Value);
        }
        #endregion

    }
}
