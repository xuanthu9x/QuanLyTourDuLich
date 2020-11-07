using System.Data;
using WindowsFormsApplication1.Model;

namespace WindowsFormsApplication1.Controller
{
    class TourBLL
    {
        TourDAL tourDal;
        public TourBLL()
        {
            tourDal = new TourDAL();
        }
        //get Ma tour
        public DataTable geMaTour()
        {
            return tourDal.GetMaTour();
        }
        public DataTable getDsMaTour()
        {
            return tourDal.GetDsMaTour();
        }
        public DataTable getAllTour()
        {
            return tourDal.getAllTour();
        }
        public DataTable LoadLoaiTour()
        {
            return tourDal.LoadLoaiTour();
        }
        public bool insertTour(Tour t)
        {
            return tourDal.insertTour(t);
        }
        public bool updateTour(Tour t)
        {
            return tourDal.UpdateTour(t);
        }
        public bool deleteTour(int matour)
        {
            return tourDal.DeleteTour(matour);
        }
        public bool insertCTTour(Tour t)
        {
            return tourDal.insertCTTour(t);
        }
        public DataTable GetCTTour(int matour)
        {
            return tourDal.GetCTTour(matour);
        }
        public bool deleteCTTour( int matour)
        {
            return tourDal.DeleteCTTour(matour);
        }
      //get infoTour
      public DataTable getInfoLoaiTour(int maTour)
        {
            return tourDal.getInfoLoaiTour(maTour);
        }

        //load ngày bắt đầu hợp lệ để edit bảng giá

        public DataTable GetTGBD(int maTour)
        {
            return tourDal.GetTGBD(maTour);
        }

    }
}
