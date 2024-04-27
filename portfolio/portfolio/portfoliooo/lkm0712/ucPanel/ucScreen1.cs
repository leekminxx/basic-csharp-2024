using MetroFramework;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lkm0712.ucPanel
{
    public partial class ucScreen1 : UserControl
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=clothes_type_DB;Integrated Security=True";
        public ucScreen1()
        {
            InitializeComponent();
        }

        private void ucScreen1_Load(object sender, EventArgs e)
        {
            pictureBox1.Tag = "15000";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Helper.Common.Clnum = 1;









            // PictureBox에서 이미지를 가져옵니다.
            PictureBox clickedPictureBox1 = sender as PictureBox;

            // 만약 PictureBox가 클릭되지 않았다면, 이벤트를 무시합니다.
            if (clickedPictureBox1 == null)
                return;

            // 여기서 해당 이미지의 정보를 데이터베이스에서 가져오는 쿼리를 수행합니다.
            // 여기서는 단순히 이미지의 이름을 출력하는 예시 코드를 작성했습니다.
            string Price = clickedPictureBox1.Tag.ToString(); // 예: 이미지 파일의 경로나 이름을 가져옵니다.

            // 데이터베이스에 연결하여 쿼리를 실행합니다.
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // 여기서 적절한 SQL 쿼리를 사용하여 이미지에 대한 정보를 가져옵니다.
                string query = "SELECT * FROM clothes WHERE Price = @Price";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Price", Price);

                // 쿼리 실행 후 결과 처리
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // 적절한 처리를 수행합니다. 예를 들어, 가져온 정보를 출력하거나 다른 작업을 수행합니다.
                    string clothesInfo = reader[1].ToString(); // 예시: 옷 정보를 가져옵니다.
                    MessageBox.Show(clothesInfo, "Clothes Information");
                }
            }
        }

    }
}
