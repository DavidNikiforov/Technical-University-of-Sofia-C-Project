namespace UserLogin
{
    class LoginValidation
    {
        // Частни низови полета за потребителско име, парола и съобщение за грешка
        private string username;
        private string password;
        private string errorMessage;

        // Публичен конструктор, който приема два параметъра за инициализация на потребителско име и парола
        public LoginValidation(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        // Други членове на класа
    }
}
