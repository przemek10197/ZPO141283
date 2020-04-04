using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZPO_cwiczenia5_2
{
    class Classroom
    {
        private List<Pupil> pupils = new List<Pupil>();
        private string className;

        public Classroom() { }

        public Classroom(string className)
        {
            this.className = className;
        }

        public void AddPupil(Pupil pupil)
        {
            pupils.Add(pupil);
        }

        public List<Pupil> GetPupilsList()
        {
            return pupils;
        }

        public string GetClassName()
        {
            return className;
        }

        public Classroom ClassroomCopy()
        {
            Classroom temp = new Classroom();
            temp.className = String.Copy(this.className);
            List<Pupil> temp1 = new List<Pupil>();
            for(int i = 0; i < pupils.Count; i++)
            {
                temp1.Add(pupils[i].PupilCopy());
            }
            temp.pupils = temp1;
            return temp;
        }
    }
}
