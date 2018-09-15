using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competitorspace
{
    class Competitor
    {
        private int Ball;
        private string Fam;
        private string _name;
        private void SetBall(int _Ball)
        {
            Ball = _Ball;
        }
        private int GetBall()
        {
            return Ball;
        }
        private void SetFam(string _Fam)
        {
            Fam = _Fam;
        }
        private string GetFam()
        {
            return Fam;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        // Тут будет функция записи данных в файлик, путь получаем из переменной
        // второго класса. Второй класс для записи и чтения из файликов.
    }
}
