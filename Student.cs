using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Save_Load
{
    public class Student
    {
        public string id;
        private string name;
        public string address;
        public string phone;

        
        public Student(string Id)
        {
            this.id = Id;
            
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(value.Length < 15)
                {
                    name = value;
                }
                else
                {
                    string temp = value;
                    name = temp.Substring(0, 15);
                }
                
            }
        }

        public void save()
        {
            string[] str1 = new string[4];
            str1[0] = id;       
            str1[1] = name;
            str1[2] = address;
            str1[3] = phone;
            File.WriteAllLines(id+".txt", str1);

        }

        public void load()
        {
            if(File.Exists(this.id + ".txt"))
            {
                string[] str2 = new string[4];
                str2 = File.ReadAllLines(this.id + ".txt");
                id = str2[0];
                name = str2[1]; 
                address = str2[2];  
                phone = str2[3];    
            }
            
        }
    }
}
