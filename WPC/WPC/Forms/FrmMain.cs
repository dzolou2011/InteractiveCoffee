using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WPC.Forms;
using WPC.Helpers;

namespace WPC
{
    public partial class frmMain : Form
    {
        private DataTable _members;


        public frmMain()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var f=new FrmAdd();
            f.OpState= OpStateEnum.Add;
            f.Show(this);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WpcHelper.LoadConfig();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var f=new FrmAdd();
            f.MemberId = _members.Rows[dataGridView1.SelectedRows[0].Index]["MemberId"].ToString();
            f.OpState = OpStateEnum.Edit;
            f.ShowDialog();
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            var errorMessage = "";
            _members = SqliteHelper.ExecuteReader(WpcHelper.DbConnection,
                @"select rowid as MemberId,firstname,middlename,lastname,Type,membersince as [Member Since],Status from members order by lastname,firstname",
                new List<SqliteParam>(), out errorMessage);


            dataGridView1.DataSource = _members;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Refresh();

            Util.ResizeDataGrid(dataGridView1);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            var f = new FrmAdd();
            f.MemberId = _members.Rows[dataGridView1.SelectedRows[0].Index]["MemberId"].ToString();
            f.OpState = OpStateEnum.Edit;
            f.ShowDialog();
        }
    }



}
