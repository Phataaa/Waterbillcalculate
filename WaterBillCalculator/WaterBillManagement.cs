using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterBillCalculator
{
    public partial class WaterBillManagement : Form
    {
        WaterBill[] listBills = new WaterBill[100];
        int n = 0;

        public WaterBillManagement()
        {
            InitializeComponent();
           
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            double waterMeterLastMonth = double.Parse(txtWaterLastMonth.Text);
            double waterMeterThisMonth = double.Parse(txtWaterThisMonth.Text);
            int customerType = cbCustomerType.SelectedIndex;
            double usageTotal = waterMeterThisMonth - waterMeterLastMonth;
            double priceUnit = 0;
            int numerPeople = 0;
            if (customerType == 0)
            {
                numerPeople = int.Parse(txtNumberPeople.Text);
                double avg = usageTotal / numerPeople;
                if (avg <= 10)
                {
                    priceUnit = 5973;
                }
                else if (avg <= 20)
                {
                    priceUnit = 7052;
                }
                else if (avg <= 30)
                {
                    priceUnit = 8699;
                }
                else
                {
                    priceUnit = 15929;
                }
            }
            if (customerType == 1)
            {
                priceUnit = 9955;
            }
            if (customerType == 2)
            {
                priceUnit = 11615;
            }
            if (customerType == 3)
            {
                priceUnit = 22068;
            }
            double totalBill = priceUnit * usageTotal;
            lblType.Text = cbCustomerType.SelectedItem.ToString();
            lblName.Text = customerName;
            lblBill.Text = totalBill + " vnđ";
            lblUsage.Text = usageTotal + " m3";
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text;
            double waterMeterLastMonth = double.Parse(txtWaterLastMonth.Text);
            double waterMeterThisMonth = double.Parse(txtWaterThisMonth.Text);
            int customerType = cbCustomerType.SelectedIndex;
            double usageTotal = waterMeterThisMonth - waterMeterLastMonth;
            double priceUnit = 0;
            int numerPeople = 0;
            if (customerType == 0)
            {
                numerPeople = int.Parse(txtNumberPeople.Text);
                double avg = usageTotal / numerPeople;
                if (avg <= 10)
                {
                    priceUnit = 5973;
                }
                else if (avg <= 20)
                {
                    priceUnit = 7052;
                }
                else if (avg <= 30)
                {
                    priceUnit = 8699;
                }
                else
                {
                    priceUnit = 15929;
                }
            }
            if (customerType == 1)
            {
                priceUnit = 9955;
            }
            if (customerType == 2)
            {
                priceUnit = 11615;
            }
            if (customerType == 3)
            {
                priceUnit = 22068;
            }
            double totalBill = priceUnit * usageTotal;

            WaterBill waterBill = new WaterBill();
            waterBill.name = customerName;
            waterBill.type = customerType;
            waterBill.lastMonth = waterMeterLastMonth;
            waterBill.thisMonth = waterMeterThisMonth;
            waterBill.totalCost = totalBill;
            waterBill.usage = usageTotal;
            waterBill.numberPeople = numerPeople;
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");
            waterBill.dateTime = formattedDateTime;
            listBills[n] = waterBill;
            n++;
            display();
            MessageBox.Show("Saved successfully");
            ClearData();
        }

        public void display()
        {
            dgvBills.DataSource = null;
            dgvBills.DataSource = listBills;
            dgvBills.Refresh();
        }

        int index;

        private void dgvBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            txtCustomerName1.Text = listBills[index].name.ToString();
            cbCustomerType1.SelectedIndex = listBills[index].type;
            txtWaterLastMonth1.Text = listBills[index].lastMonth.ToString();
            txtWaterThisMonth1.Text = listBills[index].thisMonth.ToString();
            txtNumberPeople1.Text = listBills[index].numberPeople.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string customerName = txtCustomerName1.Text;
                double waterMeterLastMonth = double.Parse(txtWaterLastMonth1.Text);
                double waterMeterThisMonth = double.Parse(txtWaterThisMonth1.Text);
                int customerType = cbCustomerType.SelectedIndex;
                double usageTotal = waterMeterThisMonth - waterMeterLastMonth;
                double priceUnit = 0;
                int numerPeople = 0;
                if (customerType == 0)
                {
                    numerPeople = int.Parse(txtNumberPeople1.Text);
                    double avg = usageTotal / numerPeople;
                    if (avg <= 10)
                    {
                        priceUnit = 5973;
                    }
                    else if (avg <= 20)
                    {
                        priceUnit = 7052;
                    }
                    else if (avg <= 30)
                    {
                        priceUnit = 8699;
                    }
                    else
                    {
                        priceUnit = 15929;
                    }
                }
                if (customerType == 1)
                {
                    priceUnit = 9955;
                }
                if (customerType == 2)
                {
                    priceUnit = 11615;
                }
                if (customerType == 3)
                {
                    priceUnit = 22068;
                }
                double totalBill = priceUnit * usageTotal;
                DateTime currentDateTime = DateTime.Now;
                string formattedDateTime = currentDateTime.ToString("yyyy/MM/dd HH:mm:ss");

                listBills[index].name = customerName;
                listBills[index].type = customerType;
                listBills[index].lastMonth = waterMeterLastMonth;
                listBills[index].thisMonth = waterMeterThisMonth;
                listBills[index].totalCost = totalBill;
                listBills[index].usage = usageTotal;
                listBills[index].numberPeople = numerPeople;
                listBills[index].dateTime = formattedDateTime;
                dgvBills.DataSource = null;
                dgvBills.DataSource = listBills;
                MessageBox.Show("Updated successfully!!");
                ClearData();
                dgvBills.Refresh();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ko?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                while (index < n)
                {
                    listBills[index] = listBills[index + 1];
                    index++;
                }
                listBills[n - 1] = null;
                n = n - 1;
                dgvBills.DataSource = null;
                dgvBills.DataSource = listBills;
                MessageBox.Show("Deleted successfully!!");
                ClearData();
                dgvBills.Refresh();
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            if (!string.IsNullOrEmpty(searchName))
            {
                bool found = false;
                List<WaterBill> temp = new List<WaterBill>();
                for (int i = 0; i < n; i++)
                {
                    if (listBills[i] != null && listBills[i].name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        dgvBills.ClearSelection();
                        temp.Add(listBills[i]);
                        dgvBills.DataSource = null;
                        dgvBills.DataSource = temp;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show($"No bills found for customer: {searchName}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter a customer name to search.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSortDESC_Click(object sender, EventArgs e)
        {
            Array.Sort(listBills, 0, n, Comparer<WaterBill>.Create((x, y) => y.totalCost.CompareTo(x.totalCost)));
            display();
        }

        private void btnSortASC_Click(object sender, EventArgs e)
        {
            Array.Sort(listBills, 0, n, Comparer<WaterBill>.Create((x, y) => x.totalCost.CompareTo(y.totalCost)));
            display();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        public void ClearData()
        {
            dgvBills.DataSource = null;
            dgvBills.DataSource = listBills;
            txtCustomerName.Text = "";
            txtWaterLastMonth.Text = "";
            txtWaterThisMonth.Text = "";
            txtNumberPeople.Text = "";
            cbCustomerType.Text = "";
            txtCustomerName1.Text = "";
            txtWaterLastMonth1.Text = "";
            txtWaterThisMonth1.Text = "";
            txtNumberPeople1.Text = "";
            cbCustomerType1.Text = "";
            txtSearch.Text = "";
            lblName.Text = "";
            lblUsage.Text = "";
            lblType.Text = "";
            lblBill.Text = "";
        }

        private void tabPageAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void cbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerType.SelectedIndex == 0)
            {
                txtNumberPeople.Visible = true;
            }
            else
            {
                txtNumberPeople.Visible = false;
            }
        }
    }
}
