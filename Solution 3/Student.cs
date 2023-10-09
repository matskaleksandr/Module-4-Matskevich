using System;
using System.Collections.Generic;

namespace Solution_3
{
    internal class Student : IStudent
    {
        private string name;//имя студента
        private int course;//курс на котором учится студент
        private List<double> grades = new List<double>();//список оценок студента
        //конструктор класса Student
        public Student(string name, int course)
        {
            this.name = name;
            this.course = course;
        }
        //метод для добавления оценки студенту
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 10)//проверка корректности оценки
            {
                grades.Add(grade);//добавление оценки в список
            }
            else
            {
                Console.WriteLine("Некорректная оценка. Оценка должна быть в диапазоне от 0 до 10.");
            }
        }
        //реализация метода GetAverageGrade() из интерфейса IStudent
        public double GetAverageGrade()
        {
            if (grades.Count == 0)
            {
                return 0.0;//если нет оценок средний балл равен 0
            }
            double sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;//суммирование оценок
            }
            return sum / grades.Count;//расчет среднего балла
        }

        //реализация метода GetCourseInfo() из интерфейса IStudent
        public string GetCourseInfo()
        {
            return $"Студент {name}, {course}-й курс";
        }

        //переопределение метода ToString() для строкового представления объекта Student
        public string ToString()
        {
            return $"{GetCourseInfo()}, Средний балл: {GetAverageGrade()}";
        }
    }
}
