using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LINQSelectSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //定义数据库连接字符串
        string strCon = "Data Source=XIAOKE\\XIAOKE;Database=db_CSharp;Uid=sa;Pwd=;";
        linqtosqlClassDataContext linq;          //声明Linq连接对象

        private void Form1_Load(object sender, EventArgs e)
        {
            BindInfo();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            BindInfo();
        }

        #region 查询员工信息
        /// <summary>
        /// 查询员工信息
        /// </summary>
        private void BindInfo()
        {
            linq = new linqtosqlClassDataContext(strCon);    //实例化Linq连接对象
            if (txtKeyWord.Text == "")
            {
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
            else
            {
                switch (cboxCondition.Text)
                {
                    case "员工编号":
                        //根据员工编号查询员工信息
                        var resultid = from info in linq.tb_Employee
                                       where info.ID == txtKeyWord.Text
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
                        dgvInfo.DataSource = resultid;
                        break;
                    case "员工姓名":
                        //根据员工姓名查询员工信息
                        var resultname = from info in linq.tb_Employee
                                         where info.Name.Contains(txtKeyWord.Text)
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
                        dgvInfo.DataSource = resultname;
                        break;
                    case "性别":
                        //根据员工性别查询员工信息
                        var resultsex = from info in linq.tb_Employee
                                        where info.Sex == txtKeyWord.Text
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
                        dgvInfo.DataSource = resultsex;
                        break;
                }
            }
        }
        #endregion
    }
}
