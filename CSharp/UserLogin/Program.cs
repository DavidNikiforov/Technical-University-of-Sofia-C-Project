using System;
using UserLogin;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инстанциране на обект от клас LoginValidation
            LoginValidation loginValidation = new LoginValidation();

            // Проверка на въведените данни от потребителя
            bool isValidInput = loginValidation.ValidateUserInput();

            // Ако въведените данни са валидни, изведи данните за администратора
            if (isValidInput)
            {
                // Задаване на тестови данни за потребителя
                UserData.TestUser = new User
                {
                    Username = "JoneDoe",
                    Password = "password123",
                    FakNum = "1234567890",
                    Role = UserRoles.ADMIN
                };

                // Данни за потребителя
                Console.WriteLine("Данни за потребителя:");
                Console.WriteLine("Потребителско име: " + UserData.TestUser.Username);
                Console.WriteLine("Парола: " + UserData.TestUser.Password);
                Console.WriteLine("Факултетен номер: " + UserData.TestUser.FakNum);
                Console.WriteLine("Роля: " + UserData.TestUser.Role);

                // Извеждане на стойността на currentUserRole
                Console.WriteLine("Текуща роля: " + LoginValidation.currentUserRole);
            }
            else
            {
                Console.WriteLine("Невалидни въведени данни за потребител");
            }
        }
    }
}
