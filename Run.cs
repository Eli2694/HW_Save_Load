using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Save_Load
{
    internal class Run
    {
        public void run()
        {
            Student student1 = new Student("111");
            student1.phone = "6439346";
            student1.address = "Karmiel";
            student1.Name = "Alex";
            student1.save();
            

            Student student2 = new Student("222");
            student2.load();
            student2.phone = "6599981";
            student2.address = "Tel-Aviv";
            student2.Name = "Gregor Rabinovich Marko Elinman";
            student2.save();
        }
    }
}
