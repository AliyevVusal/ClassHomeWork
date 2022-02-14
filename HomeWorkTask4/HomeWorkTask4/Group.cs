using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkTask4
{
    class Group : Student
    {
        public int GroupNo;
        public int GroupLimit;


        public Group(int groupno,int grouplimit)
        {
            GroupNo = groupno;
            GroupLimit = grouplimit;
        }

        

    }
}
