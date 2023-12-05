﻿using WebApp_GKH.Helpers;

namespace WebApp_GKH.Models
{
    public class Resident
    {

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public UserType Type { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateRegistration { get; set; }
        public Address Address { get; set; }


        public Resident(string name, string surname, string login, string password, string dateOfBirth, string email, string phone, Address address)
        {
            Id = Guid.NewGuid();
            FirstName = name;
            SecondName = surname;
            //Type = Id Жителя; // Id UserType
            Login = login;
            Password = password;
            DateOfBirth = Converter.ConvertStringToDate(dateOfBirth);
            Email = email;
            Phone = phone;
            DateRegistration = DateTime.Now;
            Address = address;
        }

        public Resident()
        {
            Id = Guid.NewGuid();
            //Type = Id Жителя; // Id UserType
            DateRegistration = DateTime.Now;
        }
    }

}
