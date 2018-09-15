using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Competitorspace;

namespace Competitionspace
{
   class Competition
    {
        // Количество участников
        private int _countUsers;
        // Количество победителей
        private int _countWinners;
        // Счётчик номера участника
        private int _numberUser;
        // Название конкурса
        private string _nameCompetition;
        // Список участников 
        private List<Competitor> _users;
        // Конструктор по умолчанию
        public Competition()
        {
            _nameCompetition = "Произвольный конкурс";
            _countUsers = 5;
            _countWinners = 1;
            _numberUser = 1;
            _users = new List<Competitor>();
        }
        // Установка названия конкурса
        public void SetNameCompetition(string nameCompetition)
        {
            this._nameCompetition = nameCompetition;
        }
        // Установка количество участников
        public void SetCountUsers(int countUsers)
        {
            this._countUsers = countUsers;
        }
        // Установка количество победителей
        public void SetCountWinners(int countWinners)
        {
            this._countWinners = countWinners;
        }
        // Регистрация участника
        public void AddUser(string name)
        {
            Competitor us = new Competitor();
            us.SetName(name);
            _users.Add(us);
            StreamWriter sw = new StreamWriter("Test.txt", true);
            sw.WriteLine(name + Environment.NewLine);
            sw.Close();
        }
        public string AllUsers()
        {
            string gg = "";
            foreach (var user in _users)
            {
               gg+= user.GetName() + " ";
            }
            return gg;
        }
        public string Mess()
        {
            return _nameCompetition + _countUsers + _countWinners;
        }
    }
}
