using studentClassLibrary;

namespace LabClassLibrary
{
    public partial class Form1 : Form
    {
        List<Student> listStudents = new List<Student>();
        StudentController controller = new StudentController();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            displayData();
            this.tbName.Text = "";
            this.tbID.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.saveFile();

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controller.openFile();

        }
        private void displayData()
        {
            this.tbListStudent.Text = controller.displayData();
        }
    }
}