using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Epood_Tooded
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\Ryshniak\Epood_Tooded\Tooded_DB.mdf;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter_toode, adapter_kategooria;

        public Form1()
        {
            InitializeComponent();
            NaitaKategooriad();
            NaitaAndmed();
        }



        private void button10_Click(object sender, EventArgs e)
        {

        }
        public void NaitaAndmed()
        {
            connect.Open();
            DataTable dt_toode = new DataTable();
            adapter_toode = new SqlDataAdapter("SELECT Toodetabel.Id, Toodetabel.Toodenimetus, Toodetabel.Kogus," +
                " Toodetabel.Hind, Toodetabel.Pilt, Toodetabel.Bpilt, Kategooriatable.Kategooria_nimetus" +
                " as Kategooria_nimetus FROM Toodetabel INNER JOIN Kategooriatable ON Toodetabel.Kategooriad=Kategooriatable.Id", connect);
            adapter_toode.Fill(dt_toode);
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dt_toode;
            DataGridViewComboBoxColumn combo_kat = new DataGridViewComboBoxColumn();
            combo_kat.DataPropertyName = "Kategooria_nimetus";
            HashSet<string> keys = new HashSet<string>();
            foreach (DataRow item in dt_toode.Rows)
            {
                string kat_n = item["Kategooria_nimetus"].ToString();
                if (!keys.Contains(kat_n))
                {
                    keys.Add(kat_n);
                    combo_kat.Items.Add(kat_n);
                }
            }
            dataGridView1.Columns.Add(combo_kat);
            Toode_pb.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"C:\Users\opilane\source\repos\Ryshniak\Epood_Tooded\Images"), "pood.png"));
            connect.Close();
        }

        Form popupForm;
        private void Loopilt(Image image, int r)
        {
            popupForm = new Form();
            popupForm.FormBorderStyle = FormBorderStyle.None;
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Size = new Size(200, 200);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            popupForm.Controls.Add(pictureBox);

            System.Drawing.Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(4, r, true);
            System.Drawing.Point popupLocation = dataGridView1.PointToScreen(cellRectangle.Location);

            popupForm.Location = new System.Drawing.Point(popupLocation.X + cellRectangle.Width, popupLocation.Y);
            popupForm.Show();
        }

        public void NaitaKategooriad()
        {
            connect.Open();
            adapter_kategooria = new SqlDataAdapter("SELECT Id, Kategooria_nimetus FROM Kategooriatable", connect);
            System.Data.DataTable dt_kat = new DataTable();
            adapter_kategooria.Fill(dt_kat);
            foreach (DataRow item in dt_kat.Rows)
            {
                if (!Kat_box.Items.Contains(item["Kategooria_nimetus"]))
                {
                    Kat_box.Items.Add(item["Kategooria_nimetus"]);
                }
                else
                {
                    command = new SqlCommand("DELETE FROM Kategooriatable WHERE Id=@id", connect);
                    command.Parameters.AddWithValue("@id", item["Id"]);
                    command.ExecuteNonQuery();
                }
            }
            connect.Close();
        }

        private void Lisa_Kat_btn_Click(object sender, EventArgs e)
        {
            bool on = false;
            foreach (var items in Kat_box.Items)
            {
                if (items.ToString() == Kat_box.Text)
                {
                    on = true;

                }
            }
            if (on == false)
            {
                command = new SqlCommand("INSERT INTO Kategooriatable (Kategooria_nimetus) VALUES (@kat)", connect);
                connect.Open();
                command.Parameters.AddWithValue("@kat", Kat_box.Text);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_box.Items.Clear();
                NaitaKategooriad();
            }
            else
            {
                MessageBox.Show("Selline kategooriat on juba olemas!");
            }
        }
        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            if (Kat_box.SelectedItem != null)
            {
                connect.Open();
                string kat_val = Kat_box.SelectedItem.ToString();
                command = new SqlCommand("DELETE FROM Kategooriatable WHERE Kategooria_nimetus=@kat", connect);
                command.Parameters.AddWithValue("@kat", kat_val);
                command.ExecuteNonQuery();
                connect.Close();
                Kat_box.Items.Clear();
                NaitaKategooriad();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kat_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        SaveFileDialog save;
        OpenFileDialog open;
        string extension = null;
        private void otsi_fail_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text == "")
            {
                MessageBox.Show("Palun sisesta toode nimetus enne pildi valimist!");
                return;
            }
            open = new OpenFileDialog();
            open.InitialDirectory = @"C:\Kasutaja\opilane\source\repos\Ryshniak\Epood_Tooded\Picture";
            open.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";

            FileInfo open_info = new FileInfo(@"C:\User\Student\source\repos\Ryshniak\Epood_Tooded\Picture\" + open.FileName);
            if (open.ShowDialog() == DialogResult.OK && Toode_txt.Text != null)
            {
                save = new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Images");
                save.FileName = Toode_txt.Text + Path.GetExtension(open.FileName);
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog() == DialogResult.OK && Toode_txt != null)
                {
                    File.Copy(open.FileName, save.FileName);
                    Toode_pb.Image = Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või oli vajutatud Cancel");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        byte[] imageData;
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 4)
            {
                imageData = dataGridView1.Rows[e.RowIndex].Cells["Bpilt"].Value as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image img = Image.FromStream(ms);
                        Loopilt(img, e.RowIndex);
                    }
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (popupForm != null && !popupForm.IsDisposed)
            {
                popupForm.Close();
            }

        }
        int Id = 0;
        private void Lisa_btn_Click(object sender, EventArgs e)
        {
            if (Toode_txt.Text.Trim() != string.Empty &&
                Kogus_txt.Text.Trim() != string.Empty && 
                Hind_txt.Text.Trim() != string.Empty && Kat_box.SelectedItem != null)
            {
                try
                {
                    connect.Open();
                    command = new SqlCommand("SELECT Id FROM Kategooriatable WHERE Kategooria_nimetus=@kat", connect);
                    command.Parameters.AddWithValue("@kat", Kat_box.Text);
                    command.ExecuteNonQuery();
                    Id = Convert.ToInt32(command.ExecuteScalar());
                    command = new SqlCommand("INSERT INTO Toodetabel (Toodenimetus, Kogus, Hind, Pilt, Bpilt, Kategooriad)"
                        +
                        "VALUES(@toode, @kogus, @hind, @pilt, @bpilt, @kat)", connect);
                    command.Parameters.AddWithValue("@toode", Toode_txt.Text);
                    command.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    command.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    extension = Path.GetExtension(open.FileName);
                    command.Parameters.AddWithValue("@pilt", Toode_txt.Text + extension);
                    imageData = File.ReadAllBytes(open.FileName);
                    command.Parameters.AddWithValue("@bpilt", imageData);
                    command.Parameters.AddWithValue("@kat", Id);
                    command.ExecuteNonQuery();
                    connect.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Palun täida kõik väljad!");
            }
        }

    }
}
