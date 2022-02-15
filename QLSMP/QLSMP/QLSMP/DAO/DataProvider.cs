using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSMP.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; //phím tắt đóng gói ctrl + R + E

        public static DataProvider Instance//biến thành singleton để biến nó thành lớp tồn tại duy nhất trong một chương trình
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        private string conecc = "Data Source=DESKTOP-FK0LVFC\\SQLEXPRESS;Initial Catalog=DA_QLSMP;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter=null)//parameter có thể null
        {
            DataTable data = new DataTable();

            using  (SqlConnection connection = new SqlConnection(conecc))//using khi kết thúc khối lệnh thì dữ liệu sẽ tự giải phóng
            { 
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' '); //cắt chuỗi
                    int i = 0;
                    foreach(string item in listpara)
                    {
                        if (item.Contains("@")) { 
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
      
        public int ExecuteNonQuery(string query, object[] parameter=null)//parameter có thể null
        {
                int data = 0;

                using (SqlConnection connection = new SqlConnection(conecc))//using khi kết thúc khối lệnh thì dữ liệu sẽ tự giải phóng
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);

                    if (parameter != null)
                    {
                        string[] listpara = query.Split(' '); //cắt chuỗi
                        int i = 0;
                        foreach (string item in listpara)
                        {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }  
                        }
                    }
                data = command.ExecuteNonQuery();

                    connection.Close();
                }
                return data;
            }//trả ra số trường dữ liệu thỏa  mãn
        public object ExecuteScalar(string query, object[] parameter=null)//parameter có thể null
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(conecc))//using khi kết thúc khối lệnh thì dữ liệu sẽ tự giải phóng
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' '); //cắt chuỗi
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains("@"))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }   
                    }
                }
                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
