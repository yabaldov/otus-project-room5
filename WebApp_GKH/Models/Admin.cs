﻿using WebApp_GKH.Helpers;
namespace WebApp_GKH.Models
{

    public class Admin
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public UserType Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }


        public Admin(string name, string surname, string login, string password, string dateOfBirth)
        {
            Id = Guid.NewGuid();
            FirstName = name;
            SecondName = surname;
            //Type = Id Админа; // Id UserType
            Login = login;
            Password = password;
            DateOfBirth = Converter.ConvertStringToDate(dateOfBirth);
        }

        public Admin()
        {
            Id = Guid.NewGuid();
            //Type = Id Админа; // Id UserType
        }
    }

}
