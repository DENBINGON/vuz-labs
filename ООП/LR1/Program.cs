using System;

namespace oop_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            UserClass p = new UserClass();
            Print(p);
        }

        static void Print(UserClass user){
            Console.WriteLine($"ID: {user.UserId}\nИмя: {user.name}\n" +
                $"Возраст: {user.Age}\nПол: {user.gender}\n" +
                $"Логин: {user.login}");
        }
    }
    class UserClass
    {
        private int userId;
        public string name;
        private int age;
        public string gender;
        public string login;
        private string password;
        private static int count = 0;
        public int UserId
        {
            get { return userId; }
        }
        public int Age
        {
            get { return age; }
            set { if (value >= 18) age = value; }
        }
        public UserClass(int userId, string name, int age,
            string gender, string login, string password)
        {
            this.userId = userId;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.login = login;
            this.password = password;
        }
        public UserClass()
        {
            count += 1;
            userId = count;
            name = "Иван";
            age = 18;
            gender = "M";
            login = "login";
            password = "password";
        }
    }
}
