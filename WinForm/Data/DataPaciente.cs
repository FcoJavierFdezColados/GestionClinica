using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Data
{
    public class DataPaciente
    {
        private static DataPaciente instance;

        public static DataPaciente GetInstance()
        {
            if (instance == null)
                instance = new DataPaciente();

            return instance;
        }
    }
}
