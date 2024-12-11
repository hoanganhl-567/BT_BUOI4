using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BUOI4
{
    public partial class Form1 : Form
    {
        public List<employee> employees = new List<employee>();

        public Form1()
        {
            InitializeComponent();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            employees.Add(new employee { Id = "NV001", Name = "Nguyễn Thị Thu Hằng ", Salary = 8500000 });
            employees.Add(new employee { Id = "NV002", Name = "Nguyễn Trần Minh Trí  ", Salary = 6500000 });
            RefreshGridView();
        }
            public void RefreshGridView()
        {
            dtgEmployees.DataSource = null;
            dtgEmployees.DataSource = employees;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           Form2 form2 = new Form2(this);
            form2.ShowDialog();
           
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dtgEmployees.SelectedRows.Count > 0)
            {
                int index = dtgEmployees.SelectedRows[0].Index;
                employee selectedeEmployee = employees[index];

                Form2 form2 = new Form2 (this, selectedeEmployee);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui long chon nhan vien can sua!", "Thong bao");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgEmployees.SelectedRows.Count > 0)
            {
                int index = dtgEmployees.SelectedRows[0].Index;
                employees.RemoveAt(index);
                RefreshGridView();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo");
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }
    }
    }

