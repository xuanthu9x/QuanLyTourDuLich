using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Controller
{
    class GiaBLL
    {
        GiaDAL giaDal;
        public GiaBLL()
        {
            giaDal = new GiaDAL();
        }
        public bool insertGia(Gia g)
        {
            return giaDal.insertGia(g);
        }
        public DataTable GetGiaTour(int matour)
        {
            return giaDal.GetGiaour(matour);
        }
        public bool deleteGiaTour( int matour)
        {
            return giaDal.DeleteGiaTour(matour);
        }
        public DataTable getTenLCP()
        {
            return getTenLCP();
        }
    }
}
