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
            // Получение данных
            using (ApplicationContext database = new ApplicationContext())
            {
                // Получаем объекты из БД и выводим на консоль
                var users = database.Users.ToList();
                labelUsers.Text = "Список пользователей: ";
                foreach (User user in users)
                {
                    labelInfoAboutUsers.Text += ($"{user.Id}.{user.Name} - {user.Age} \n");
                }
            }
        }
    }
}
