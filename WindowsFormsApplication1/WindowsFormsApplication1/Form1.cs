using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "Driver={Client Access ODBC Driver (32-bit)};System=10.9.2.121;Uid=DDSWWWGOG;Pwd=MAN162534;";
            string cadena = "SELECT * FROM EDBLIBPR.EDBFFCREHI";
            OdbcDataAdapter adp1 = new OdbcDataAdapter(cadena, con);
            DataTable dt = new DataTable();
            adp1.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
        }
    }
}
