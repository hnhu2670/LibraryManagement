namespace QL_Thư_viện
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            ColumnHeader name = new ColumnHeader();
            name.Text = "Họ tên";
            ColumnHeader id = new ColumnHeader();
            id.Text = "MSSV";
            ColumnHeader ns = new ColumnHeader();
            ns.Text = "Ngày sinh";
            ColumnHeader phai = new ColumnHeader();
           phai.Text = "Điện thoại";

            listView1.View = View.Details;
            name.Width = (int)(0.25 * listView1.Width);
            ns.Width = (int)(0.25 * listView1.Width);
            id.Width = (int)(0.25 * listView1.Width);
            phai.Width = (int)(0.25 * listView1.Width);

            listView1.Columns.Clear();
            listView1.Columns.AddRange(new ColumnHeader[] { name, id, ns,phai });
        }

        
    }
}