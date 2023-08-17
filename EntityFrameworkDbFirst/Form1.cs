using EntityFrameworkDbFirst.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirst
{
    public partial class Form1 : Form
    {
        private MYDATABASEEntities dbcontext;
        public Form1()
        {
            InitializeComponent();
            dbcontext = new MYDATABASEEntities();
        }

        private void selectbtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dbcontext.COUNTRies.Select(s => new { s.ID, s.COUNTRYNAME }).ToList();
        }

        private void insertbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string countryName = inserttxt.Text.Trim();

                if (string.IsNullOrEmpty(countryName))
                {
                    MessageBox.Show("Please Add Country Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                COUNTRY country = new COUNTRY()
                {
                    COUNTRYNAME = inserttxt.Text.Trim(),
                };
                dbcontext.COUNTRies.Add(country);
                dbcontext.SaveChanges();
                MessageBox.Show("Country inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting country: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int countryid = int.Parse(searchtxt.Text.Trim());

                var searchresult = dbcontext.COUNTRies.FirstOrDefault(s => s.ID == countryid);

                if (searchresult != null)
                {
                    dataGridView1.DataSource = new List<COUNTRY> { searchresult };
                }
                else
                {
                    MessageBox.Show("Country not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please add Id to search {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int countryid = int.Parse(updateidtxt.Text.Trim());
                var updateresult = dbcontext.COUNTRies.FirstOrDefault(s => s.ID == countryid);

                if (updateresult!=null)
                {
                    updateresult.COUNTRYNAME = updatetxt.Text.Trim();
                    dbcontext.SaveChanges();
                    MessageBox.Show("Country updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                  else
                {
                    MessageBox.Show("Country not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating country: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                int countryid = int.Parse(deleteidtxt.Text.Trim());
                var deleteresult = dbcontext.COUNTRies.FirstOrDefault(s => s.ID == countryid);

                if (deleteresult != null)
                {
                    dbcontext.COUNTRies.Remove(deleteresult);
                    dbcontext.SaveChanges();
                    MessageBox.Show("Country deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Country not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting country: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
