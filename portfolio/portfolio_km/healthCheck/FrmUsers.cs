using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace healthCheck
{
    public partial class FrmUsers : MetroForm
    {
        public static readonly string connString = "Data Source=localhost;" +
                                    "Initial Catalog=healthCheck;" +
                                    "Persist Security Info=True;" +
                                    "User ID=sa;Encrypt=False;Password=mssql_p@ss";
        public FrmUsers()
        {
            InitializeComponent();
            RefreshData(); 
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                var query = @"SELECT [MemberIdx]
                                    ,[MemberNames]
                                    ,[MemberKg]
                                    ,[MemberCm]
                                FROM [Membertbl]"; // 화면에 필요한 테이블 쿼리 변경
                                                              // 화면에 필요한 테이블 쿼리 변경

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Membertbl");

                DgvUsers.DataSource = ds.Tables[0];
                DgvUsers.ReadOnly = true; // 수정불가
                DgvUsers.Columns[0].HeaderText = "고객 ID";
                DgvUsers.Columns[1].HeaderText = "고객명";
                DgvUsers.Columns[2].HeaderText = "몸무게";
                DgvUsers.Columns[3].HeaderText = "키";
            }
        }

    }
}
