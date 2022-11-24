using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace NewProyect
{
    public class Student
    {
        private int id; 
        private string name;
        private string surname;
        private string groupNo;

        public string? Name
        {
            get => name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }
        public string ?Surname
        {
            get => surname;
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    surname = value;
                }   
            }
        }
        public string? GroupNo 
        { 
            get => groupNo;
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    groupNo = value;
                }
                else
                {
                    Console.WriteLine("custom exception ");
                }
            }
        
        }
        public int Id
        {
            get => id; 
            set
            {
                
            }
        }
        public Student(string name,string surname,string groupNo)
        {
            Name=name;
            Surname=surname;
            GroupNo=groupNo;
            id++;
            Id = id;

        }
        public string StudentInfo() =>$"Name:{Name} Surname: {Surname} GroupNo: {GroupNo} ID:{Id}";
        

        
    }
}
