using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tool_GenMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateEmails()
        {
            // Xóa danh sách email cũ trong ListBox
            lstMailGen.Items.Clear();

            // Kiểm tra xem TextBox tên và TextBox số lượng email có giá trị không
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(txtCountMail.Text))
            {
                // Lấy thông tin từ TextBox tên và ComboBox định dạng mail
                string name = textBox1.Text;
                string domain = txtNhapDomain.Text;

                // Lấy số lượng email từ TextBox số lượng email
                if (int.TryParse(txtCountMail.Text, out int quantity))
                {

                    for (int i = 1; i <= quantity; i++)
                    {
                        string email = $"{name}{i}@{domain}";
                        lstMailGen.Items.Add(email);
                    }

                    // Tạo và hiển thị danh sách email với dấu chấm trong ListBox
                    for (int i = 1; i <= quantity; i++)
                    {
                        string emailWithDot = $"{name}.{i}@{domain}";
                        lstMailGen.Items.Add(emailWithDot);
                    }

                    // Tạo và hiển thị danh sách email với dấu gạch chân trong ListBox
                    for (int i = 1; i <= quantity; i++)
                    {
                        string emailWithUnderscore = $"{name}_{i}@{domain}";
                        lstMailGen.Items.Add(emailWithUnderscore);

                    }
                }
            }
        }
        private void btnGenMail_Click(object sender, EventArgs e)
        {

            GenerateEmails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void cbChonLoaiMail_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtCountMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại lưu file và lưu danh sách email vào file txt
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.FileName = "listmail.txt"; // Đặt tên mặc định cho file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lưu danh sách email vào file txt
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var item in lstMailGen.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
                MessageBox.Show("Danh sách email đã được lưu vào file.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      

        private void lstMailGen_SelectedIndexChanged(object sender, EventArgs e)
        {




        }

        private void chkRanDomText_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}