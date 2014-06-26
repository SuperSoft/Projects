using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NPOIExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Users");
            dt.Columns.Add("id", typeof(string));
            dt.Columns.Add("User", typeof(string));
            dt.Columns.Add("Sex", typeof(string));
            dt.Columns.Add("Tel", typeof(string));
            dt.Columns.Add("Remark", typeof(string));

            DataRow newRow = dt.NewRow();
            newRow["id"] = "1";
            newRow["User"] = "Magic";
            newRow["Sex"] = "M";
            newRow["Tel"] = "123456";
            newRow["Remark"] = "";
            dt.Rows.Add(newRow);

            IList<string> columnsTexts = new List<string>();
            columnsTexts.Add("编号");
            columnsTexts.Add("用户");
            columnsTexts.Add("性别");
            columnsTexts.Add("电话");
            columnsTexts.Add("备注");

            NPOIHelper.NPOIHelper.Export(dt, "导出测试", "Users.xls", columnsTexts);

            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("编号", "id");
            d.Add("用户", "User");
            d.Add("性别", "Sex");
            d.Add("电话", "Tel");
            d.Add("备注", "Remark");

            DataTable t= NPOIHelper.NPOIHelper.Import("Users.xls", d);

            gridControl1.DataSource = t.DefaultView;
        }
    }
}
