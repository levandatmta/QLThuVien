using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAO;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien.BUS
{
    
    class MatKhau_BUS
    {
       
        public bool CheckExist(string _tdn, string _mkc)
        {
            return mkDao.CheckExist(_tdn, _mkc);

        }
    }
}
