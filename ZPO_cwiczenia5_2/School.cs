using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5_2
{
    class School
    {
        private List<Classroom> cls = new List<Classroom>();
        private string address;

        public School() { }

        public School(string address)
        {
            this.address = address;
        }

        public void AddClassroom(Classroom classroom) 
        {
            cls.Add(classroom); 
        }

        public List<Classroom> GetClassList()
        {
            return cls;
        }

        public string GetAddress()
        {
            return address;
        }

        public School SchoolCopy()
        {
            School temp = new School();
            temp.address = String.Copy(address);
            List<Classroom> temp1 = new List<Classroom>();
            for(int i=0; i < cls.Count; i++)
            {
                temp1.Add(cls[i]);
            }
            temp.cls = temp1;
            return temp;
        }
    }
}
