using System.Data.SQLite;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //Agregamos la base de datos
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";
        //La base de datos de crea en la carpeta debug
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();

            string stm = "SELECT * FROM test";
            var cmd = new SQLiteCommand(stm, con);
            dr =cmd.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Insert(0,dr.GetString(0), dr.GetString(1));
            }
        }
    }
}
