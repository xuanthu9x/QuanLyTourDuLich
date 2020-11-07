using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Controller
{
    class DiaDiemBLL
    {
        DiaDiemDAL ddDal;
        public DiaDiemBLL()
        {
            ddDal = new DiaDiemDAL();

        }
        public DataTable GetAllDiaDiem()
        {
            return ddDal.getAllDiaDiem();
        }
    }
}
