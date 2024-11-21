namespace LB1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ��������� ������
            using (ApplicationContext database = new ApplicationContext())
            {
                // �������� ������� �� �� � ������� �� �������
                var users = database.Users.ToList();
                labelUsers.Text = "������ �������������: ";
                foreach (User user in users)
                {
                    labelInfoAboutUsers.Text += ($"{user.Id}.{user.Name} - {user.Age} \n");
                }
            }
        }
    }
}
