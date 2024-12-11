using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT_BUOI4
{
    public partial class Form2 : Form
    {
        private Form1 _form1; // Tham chiếu đến Form1
        private employee _employee; // Nhân viên cần sửa (nếu có)
        public Form2(Form1 form1, employee employee = null)
        {
            InitializeComponent();
            _form1 = form1;
            _employee = employee;

            if (_employee != null)
            {
                // Hiển thị thông tin nhân viên nếu đang sửa
                txtMSSV.Text = _employee.Id;
                txtTennhanvien.Text = _employee.Name;
                txtLuongcanban.Text = _employee.Salary.ToString();
               
            }
        }


        private void btn_dongy_Click_1(object sender, EventArgs e)
        {
            if (_employee == null) // Trường hợp thêm mới
            {
                employee newEmployee = new employee
                {
                    Id = txtMSSV.Text,
                    Name = txtTennhanvien.Text,
                    Salary = double.Parse(txtLuongcanban.Text)
                };

                _form1.employees.Add(newEmployee); // Thêm vào danh sách
            }
            else // Trường hợp sửa
            {
                _employee.Name = txtTennhanvien.Text;
                _employee.Salary = double.Parse(txtLuongcanban.Text);
            }

            _form1.RefreshGridView(); // Làm mới DataGridView
            this.Close(); // Đóng Form2
        }

        private void btn_boqua_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form2 mà không làm gì

        }
    }
}
