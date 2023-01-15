using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Student
    {
        private string _name;
        private string _id;
        private int _birthYear;
        private int _height;
        private double _grade;
        private string _faculty;

        public Student(string name, string id, int birthYear, int height, double grade, string faculty)
        {
            this._name = name;
            this._id = id;
            this._birthYear = birthYear;
            this._height = height;
            this._grade = grade;
            this._faculty = faculty;
        }
        public string Name
        {
            get { return _name; }
        }
        public string ID
        {
            get { return _id; }
        }
        public int BirthYear
        {
            get { return _birthYear; }
        }
        public int Height
        {
            get { return _height; }
        }
        public double Grade
        {
            get { return _grade; }
        }
        public string Faculty
        {
            get { return _faculty; }
        }
        public int myAge(){
            int age = 2023 - _birthYear;
            return age;
        }


        ////constructure
        /* public Student(String name, String id, int age, String birthYear, int height, int grand, String faculty) {
             this._name = name;
             this._id = id;
             this._age = age;
             this._birthYear = birthYear;
             this._height = height;
             this._grand = grand;
             this._faculty = faculty;
         }*/

        /*public int myAge(){
            //int age = 2023 - _birthYear;
            //return age;
        }*/
    }
}

