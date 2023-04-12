using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQAddSql
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
        linqtosqlClassDataContext linq;          //声明Linq连接对象
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            linq = new linqtosqlClassDataContext(strCon);    //实例化Linq连接对象
            tb_Employee employee = new tb_Employee();   //实例化tb_Employee类对象
            //为tb_Employee类中的员工实体赋值
            employee.ID = txtID.Text;
            employee.Name = txtName.Text;
            employee.Sex = cboxSex.Text;
            employee.Age = Convert.ToInt32(txtAge.Text);
            employee.Tel = txtTel.Text;
            employee.Address = txtAddress.Text;
            employee.QQ = Convert.ToInt32(txtQQ.Text);
            employee.Email = txtEmail.Text;
            linq.tb_Employee.InsertOnSubmit(employee);  //添加员工信息
            linq.SubmitChanges();                       //提交操作
            MessageBox.Show("数据添加成功");
            BindInfo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        #region 显示所有员工信息
        /// <summary>
        /// 显示所有员工信息
        /// </summary>
        private void BindInfo()
        {
            linq = new linqtosqlClassDataContext(strCon);    //实例化Linq连接对象
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
            dgvInfo.DataSource = result;            //对DataGridView控件进行数据绑定
        }
        #endregion
    }
}
