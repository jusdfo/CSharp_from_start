using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQDelSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义数据库连接字符串
        string strCon = "Data Source=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=;";
        linqtosqlClassDataContext linq;//声明Linq连接对象
        string strID = "";//记录选中的员工编号

        private void Form1_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void dgvInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //获取选中的员工编号
            strID = Convert.ToString(dgvInfo[0, e.RowIndex].Value).Trim();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strID == "")
            {
                MessageBox.Show("请选择要删除的记录");
                return;
            }
            linq = new linqtosqlClassDataContext(strCon);//实例化Linq连接对象
            //查找要删除的员工信息
            var result = from employee in linq.tb_Employee
                         where employee.ID == strID
                         select employee;
            linq.tb_Employee.DeleteAllOnSubmit(result); //删除员工信息
            linq.SubmitChanges();                       //实例化Linq连接对象提交操作
            MessageBox.Show("员工信息删除成功");
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
