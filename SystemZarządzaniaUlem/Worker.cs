using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace SystemZarządzaniaUlem
{
    class Worker
    {
        public Worker(string[] jobs)
        {
            jobsICanDo = jobs;
        }
        public string CurrentJob { get;}
        public int ShiftsLeft { get;}

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        public bool DoThisJob()
        {
            if (String.IsNullOrEmpty(CurrentJob))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool WorkOneShift()
        {
            return true;
        }
    }
}
