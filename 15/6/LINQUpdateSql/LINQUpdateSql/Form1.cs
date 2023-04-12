using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQUpdateSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 定义公共变量及Linq连接对象
        //定义数据库连接字符串
        string strCon = "Data Source=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=;";
        linqtosqlClassDataContext linq;							//声明Linq连接对象
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            linq = new linqtosqlClassDataContext(strCon);    //实例化Linq连接对象
            //获取选中的员工编号
            txtID.Text = Convert.ToString(dgvInfo[0, e.RowIndex].Value).Trim();
            //根据选中的员工编号获取其详细信息，并重新成成一个表
            var result = from info in linq.tb_Employee
                         where info.ID == txtID.Text
                         select new
                         {
                             ID = info.ID,
                             Name = info.Name,
                             Sex = info.Sex,
                             Age = info.Age,
                             Tel = info.Tel,
                             Address = info.Address,
                             QQ = info.QQ,
                             Email = info.Email
                         };
            //相应的文本框及下拉列表中显示选中员工的详细信息
            foreach (var item in result)
            {
                txtName.Text = item.Name;
                cboxSex.Text = item.Sex;
                txtAge.Text = item.Age.ToString();
                txtTel.Text = item.Tel;
                txtAddress.Text = item.Address;
                txtQQ.Text = item.QQ.ToString();
                txtEmail.Text = item.Email;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("请选择要修改的记录");
                return;
            }
            linq = new linqtosqlClassDataContext(strCon);    //实例化Linq连接对象
            //查找要修改的员工信息
            var result = from employee in linq.tb_Employee
                         where employee.ID == txtID.Text
                         select employee;
            //对指定的员工信息进行修改
            foreach (tb_Employee tbemployee in result)
            {
                tbemployee.Name = txtName.Text;
                tbemployee.Sex = cboxSex.Text;
                tbemployee.Age = Convert.ToInt32(txtAge.Text);
                tbemployee.Tel = txtTel.Text;
                tbemployee.Address = txtAddress.Text;
                tbemployee.QQ = Convert.ToInt32(txtQQ.Text);
                tbemployee.Email = txtEmail.Text;
                linq.SubmitChanges();
            }
            MessageBox.Show("员工信息修改成功");
            BindInfo();
        }

        #region 显示所有员工信息
        /// <summary>
        /// 显示所有员工信息
        /// </summary>
        private void BindInfo()
        {
            linq = new linqtosqlClassDataContext(strCon);//实例化Linq连接对象
            //获取所有员工信息
            var result = from info in linq.tb_Employee
                         select new
                         {
                             员工编号 = info.ID,
                             员工姓名 = info.Name,
                             性别 = info.Sex,
                             年龄 = info.Age,
                             电话 = info.Tel,
                             地址 = info.Address,
                             QQ = info.QQ,
                             Email = info.Email
                         };
            dgvInfo.DataSource = result;//对DataGridView控件进行数据绑定
        }
        #endregion

    }
}
