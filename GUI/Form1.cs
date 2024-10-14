using BUS;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GUI
{
    public partial class Form1 : Form
    {
        private StudentService studentService;

        public readonly StudentService StudentSevice = new StudentService();
        FacultyService facultyService = new FacultyService();
       

        public Form1()
        {
            InitializeComponent();
            studentService = new StudentService();
            loadFaculty();
        }
        public void loadFaculty()
        {
            List<Faculty> FacultyList = facultyService.GetAll();
            cmbKhoa.DataSource = FacultyList;
            cmbKhoa.DisplayMember = "FacultyName";
            cmbKhoa.ValueMember = "FacultyID";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            var student = studentService.getAll();
            dataGridView1.DataSource = student; // Đổ dữ liệu vào DataGridView
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Chức năng xóa sinh viên
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int studentId = (int)selectedRow.Cells[0].Value;

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    studentService.Delete(studentId);
                    MessageBox.Show("Xóa sinh viên thành công.");
                    LoadStudents();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSV.Text) ||
        string.IsNullOrWhiteSpace(txtHoten.Text) ||
        string.IsNullOrWhiteSpace(txtDiemTB.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sinh viên.");
                return;
            }

            // Tạo đối tượng sinh viên mới
            var student = new Student
            {
                StudentID = 0, // ID sẽ được tự động sinh ra
                FullName = txtHoten.Text,
                FacultyID = (int)cmbKhoa.SelectedValue,
                AverageScore = double.TryParse(txtDiemTB.Text, out double score) ? score : 0,
                MajorID = checkBox1.Checked ? null : (int?)cmbKhoa.SelectedValue
            };

            try
            {
                // Gọi phương thức Add từ StudentService
                studentService.Add(student);
                MessageBox.Show("Thêm sinh viên thành công.");

                // Tải lại danh sách sinh viên
                LoadStudents();

                // Xóa dữ liệu trong các trường nhập
                txtMSV.Clear();
                txtHoten.Clear();
                txtDiemTB.Clear();
                cmbKhoa.SelectedIndex = -1; // Reset ComboBox
                checkBox1.Checked = false; // Reset Checkbox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message);
            }
        }


        private Image LoadImage(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch
            {
                return null; // Hoặc hình ảnh mặc định
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    txtAnh.Text = filePath;
                    pictureBox1.Image = new Bitmap(filePath); // Hiển thị hình ảnh
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                int studentId = (int)selectedRow.Cells[0].Value;

                // Kiểm tra dữ liệu đầu vào
                if (!string.IsNullOrWhiteSpace(txtHoten.Text) &&
                    !string.IsNullOrWhiteSpace(txtDiemTB.Text))
                {
                    // Chức năng sửa
                    var student = new Student
                    {
                        StudentID = studentId,
                        FullName = txtHoten.Text,
                        FacultyID = (int)cmbKhoa.SelectedValue,
                        AverageScore = double.TryParse(txtDiemTB.Text, out double score) ? score : 0,
                        MajorID = checkBox1.Checked ? null : (int?)cmbKhoa.SelectedValue
                    };

                    try
                    {
                        studentService.Update(student);
                        MessageBox.Show("Sửa sinh viên thành công.");

                        // Tải lại danh sách sinh viên
                        LoadStudents();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi sửa sinh viên: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin để sửa sinh viên.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để sửa.");
            }
        }
    }      
}

