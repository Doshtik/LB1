namespace LB1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Добавление данных
            using (ApplicationContext database = new ApplicationContext())
            {
                // Создаем два объекта User
                User user1 = new User { Name = "Tom", Age = 33 };
                User user2 = new User { Name = "Alice", Age = 26 };

                // Добавляем их в БД
                database.Users.AddRange(user1, user2);
                database.SaveChanges();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}