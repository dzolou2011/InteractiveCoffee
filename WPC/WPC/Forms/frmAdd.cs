using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using WPC.Helpers;

namespace WPC.Forms
{
    public partial class FrmAdd : Form
    {

        public OpStateEnum OpState { get; set; }
        public string MemberId { get; set; }
        public DataTable MemberDepartments { get; set; }
        public DataTable MemberMinistry { get; set; }

        private DataTable _ministries;
        private DataTable _departments;
        private bool _modifiedMinistries;
        private bool _modifiedDepartments;

        public FrmAdd()
        {
            InitializeComponent();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }


        private void frmAdd_Activated(object sender, EventArgs e)
        {


            var errorMessage = "";
            cbDepartment.DataSource = SqliteHelper.ExecuteReader(WpcHelper.DbConnection,
                "select rowid,Department from departments order by Department",
                new List<SqliteParam>(), out errorMessage);
            cbDepartment.Refresh();

            cbMinistries.DataSource = SqliteHelper.ExecuteReader(WpcHelper.DbConnection,
                "select rowid,ministry from Ministries order by ministry",
                new List<SqliteParam>(), out errorMessage);

            cbMinistries.Refresh();


            dvDepartments.DataSource = MemberDepartments;
            dvDepartments.Refresh();

            dvMinistries.DataSource = MemberMinistry;
            dvMinistries.Refresh();

            if (dvDepartments.Columns.Count > 0)
            {
                dvDepartments.Columns[0].Visible = false;
                dvDepartments.Columns[1].Visible = false;
            }
            if (dvMinistries.Columns.Count > 0)
            {
                dvMinistries.Columns[0].Visible = false;
                dvMinistries.Columns[1].Visible = false;
            }

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            var errorMessage = "";
            cbMinistries.ValueMember = "rowid";
            cbMinistries.DisplayMember = "ministry";

            cbDepartment.ValueMember = "rowid";
            cbDepartment.DisplayMember = "Department";

            MemberMinistry = SqliteHelper.ExecuteReader(WpcHelper.DbConnection,
                   @"select a.rowid,a.ministryid,b.ministry from memberministries a
                     inner join ministries b on a.ministryid=b.rowid
                     where a.memberid=@memberid",
                   new List<SqliteParam>
                   {
                        new SqliteParam("memberid", MemberId, DbType.String)
                   }, out errorMessage);

            MemberDepartments = SqliteHelper.ExecuteReader(WpcHelper.DbConnection,
                @"select a.rowid,a.departmentid,b.department,a.start,a.end from memberdepartments a 
                      inner join departments b on a.departmentid=b.rowid
                      where a.memberid=@memberid",
                new List<SqliteParam>
                {
                        new SqliteParam("memberid", MemberId, DbType.String)
                }, out errorMessage);

            _ministries = SqliteHelper.ExecuteReader(WpcHelper.DbConnection, "select rowid,ministry from ministries",
                new List<SqliteParam>
                {

                }, out errorMessage);
            _departments = SqliteHelper.ExecuteReader(WpcHelper.DbConnection, "select rowid,department from departments",
               new List<SqliteParam>
               {

               }, out errorMessage);

            if (OpState == OpStateEnum.Edit)
            {
                var dt = SqliteHelper.ExecuteReader(WpcHelper.DbConnection,
                    "select * from members where rowid='" + MemberId + "'",
                    new List<SqliteParam>(), out errorMessage);
                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    tbFirstName.Text = row["firstname"].ToString();
                    tbMiddleName.Text = row["middlename"].ToString();
                    tbLastName.Text = row["lastname"].ToString();
                    tbStreetAddress.Text = row["street"].ToString();
                    tbBarangay.Text = row["barangay"].ToString();
                    tbCity.Text = row["city"].ToString();
                    tbCountry.Text = row["country"].ToString();
                    dtBirthDate.Value = DateTime.Parse(row["birthdate"].ToString());
                    cbCivilStatus.Text = row["civilstatus"].ToString();
                    tbMobile.Text = row["mobile"].ToString();
                    tbLandLine.Text = row["landline"].ToString();
                    tbOccupation.Text = row["occupation"].ToString();
                    cbMemberType.Text = row["type"].ToString();
                    cbStatus.Text = row["status"].ToString();
                }
                else
                    MessageBox.Show("Unable to load record #" + MemberId);
            }


            dvDepartments.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);


        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeptAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var row = MemberDepartments.NewRow();
                row.ItemArray = new[] { cbDepartment.SelectedValue, cbDepartment.Text, dtStart.Value, dtEnd.Value.Date };
                MemberDepartments.Rows.Add(row);

                Util.ResizeDataGrid(dvDepartments);
                _modifiedDepartments = true;
            }
            catch (Exception)
            {
            }


        }

        private void btnDeptDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dvDepartments.SelectedRows.Count > 0)
                {
                    MemberDepartments.Rows[dvDepartments.SelectedRows[0].Index].Delete();
                    Util.ResizeDataGrid(dvDepartments);

                    _modifiedDepartments = true;
                }

            }
            catch (Exception)
            {
            }

        }

        private void BtnMinistryDeleteClick(object sender, EventArgs e)
        {
            try
            {

                if (dvMinistries.SelectedRows.Count > 0)
                {
                    MemberMinistry.Rows[dvMinistries.SelectedRows[0].Index].Delete();
                    Util.ResizeDataGrid(dvMinistries);
                    _modifiedMinistries = true;
                }

            }
            catch (Exception)
            {
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinistryAdd_Click(object sender, EventArgs e)
        {
            var row = MemberMinistry.NewRow();
            row.ItemArray = new[] { cbMinistries.SelectedValue, cbMinistries.Text };
            MemberDepartments.Rows.Add(row);

            Util.ResizeDataGrid(dvDepartments);


            _modifiedMinistries = true;
        }

        private void Save()
        {
            var errorMessage = "";
            if (OpState == OpStateEnum.Add)
            {
                var sql =
                    @"insert into members(firstname,middlename,lastname,street,barangay,city,country,birthdate,civilstatus,
                         mobile,landline,occupation,type,status,membersince) values (@firstname,@middlename,@lastname,@street,
                         @barangay,@city,@country,@birthdate,@civilstatus,@mobile,@landline,@occupation,@type,@status,@membersince)";
                SqliteHelper.ExecuteNonQuery(WPC.WpcHelper.DbConnection, sql, new List<SqliteParam>
                {
                    new SqliteParam("firstname", tbFirstName.Text.Trim(), DbType.String),
                    new SqliteParam("middlename", tbMiddleName.Text.Trim(), DbType.String),
                    new SqliteParam("lastname", tbLastName.Text.Trim(), DbType.String),
                    new SqliteParam("street", tbStreetAddress.Text.Trim(), DbType.String),
                    new SqliteParam("barangay", tbBarangay.Text.Trim(), DbType.String),
                    new SqliteParam("city", tbCity.Text.Trim(), DbType.String),
                    new SqliteParam("country", tbCountry.Text.Trim(), DbType.String),
                    new SqliteParam("birthdate", dtBirthDate.Value.Date, DbType.Date),
                    new SqliteParam("civilstatus", cbCivilStatus.Text.Trim(), DbType.String),
                    new SqliteParam("mobile", tbMobile.Text.Trim(), DbType.String),
                    new SqliteParam("landline", tbLandLine.Text.Trim(), DbType.String),
                    new SqliteParam("occupation", tbOccupation.Text.Trim(), DbType.String),
                    new SqliteParam("type", cbMemberType.Text.Trim(), DbType.String),
                    new SqliteParam("status", cbStatus.Text.Trim(), DbType.String),
                    new SqliteParam("membersince", dtMemberSince.Value.Date, DbType.Date),
                    //new SqliteParam("staff", cbStaff.Checked, DbType.Boolean),
                }, out errorMessage);
            }
            else
            {
                var sql =
                    @"update members set firstname=@firstname,middlename=@middlename,lastname=@lastname,street=@street,barangay=@barangay,
                         city=@city,country=@country,birthdate=@birthdate,civilstatus=@civilstatus,
                         mobile=@mobile,landline=@landline,occupation=@occupation,type=@type,status=@status,membersince=@membersince
                         where rowid=@rowid";
                SqliteHelper.ExecuteNonQuery(WpcHelper.DbConnection, sql, new List<SqliteParam>
                {
                    new SqliteParam("firstname", tbFirstName.Text.Trim(), DbType.String),
                    new SqliteParam("middlename", tbMiddleName.Text.Trim(), DbType.String),
                    new SqliteParam("lastname", tbLastName.Text.Trim(), DbType.String),
                    new SqliteParam("street", tbStreetAddress.Text.Trim(), DbType.String),
                    new SqliteParam("barangay", tbBarangay.Text.Trim(), DbType.String),
                    new SqliteParam("city", tbCity.Text.Trim(), DbType.String),
                    new SqliteParam("country", tbCountry.Text.Trim(), DbType.String),
                    new SqliteParam("birthdate", dtBirthDate.Value.Date, DbType.Date),
                    new SqliteParam("civilstatus", cbCivilStatus.Text.Trim(), DbType.String),
                    new SqliteParam("mobile", tbMobile.Text.Trim(), DbType.String),
                    new SqliteParam("landline", tbLandLine.Text.Trim(), DbType.String),
                    new SqliteParam("occupation", tbOccupation.Text.Trim(), DbType.String),
                    new SqliteParam("type", cbMemberType.Text.Trim(), DbType.String),
                    new SqliteParam("status", cbStatus.Text.Trim(), DbType.String),
                    new SqliteParam("membersince", dtMemberSince.Value.Date, DbType.Date),
                    new SqliteParam("rowid", MemberId, DbType.String),
                }, out errorMessage);
            }
            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                // clear existing
                SqliteHelper.ExecuteNonQuery(WpcHelper.DbConnection,
                    "delete from memberministries where memberid='" + MemberId + "'", new List<SqliteParam>(),
                    out errorMessage);
                // save the memberministries
                foreach (DataRow row in MemberMinistry.Rows)
                    SqliteHelper.ExecuteNonQuery(WpcHelper.DbConnection, "insert into memberministries values(@memberid,@ministryid)",
                        new List<SqliteParam>
                        {
                            new SqliteParam("memberid",MemberId,DbType.String),
                            new SqliteParam("ministryid", row["ministryid"].ToString(),DbType.String)
                        }, out errorMessage);

                MessageBox.Show("Successfully saved member data");
                Close();
            }
            else
                MessageBox.Show("Failed saving. Error message " + errorMessage);

        }
    }


    public enum OpStateEnum
    {
        None,
        Edit,
        Add,
        View
    }
}
