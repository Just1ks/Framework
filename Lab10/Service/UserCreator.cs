using Lab10.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10.Service
{
    public static class UserCreator
    {
        //Тестовые данные
        public static string UserNameTestData = "Вася";
        public static string UserSurnameTestData = "Барыжкин";
        public static string UserEmailTestData = "vasyabar@gmail.com";

        public static User WithCredentials()
        {
            return new User(UserNameTestData, UserSurnameTestData, UserEmailTestData);
        }

    }
}
