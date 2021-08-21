﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Пользователь.
    /// </summary>
    [Serializable]
    public class User
    {
        #region Свойства
        public int Id { get; set; }
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата рождения.
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Пол.
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// Вес.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        public double Height { get; set; }

        // DateTime nowDate = DateTime.Today;
        // int age = nowDate.Year - birthDate.Year;   // верное 
        // if(birthDate > nowDate.AddYears(-age)) age--;
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } } // не верное вычисление года рождения, может баговать
        #endregion
        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthDate">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        public User() { }
        public User(string name,
                    Gender gender,
                    DateTime birthDate,
                    double weight,
                    double height)
        {
            #region Проверка входящих условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));

            }
            if(gender == null)
            {
                throw new ArgumentNullException("Пол не может быть null.", nameof(gender));

            }
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthDate));

            }
            if(weight <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю.", nameof(weight));

            }
            if(height <= 0)
            {
                throw new ArgumentException("Вес не может быть меньше или равен нулю.", nameof(height));

            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым или null.", nameof(name));

            }
            Name = name;
        }
        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
