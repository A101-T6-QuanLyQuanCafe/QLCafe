using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CAFEDAL
    {
        QLCAFEDataContext ql = new QLCAFEDataContext();
        public List<LOAISANPHAM> getloaisp()
        {

            var data = (from dt in ql.LOAISANPHAMs select dt).ToList();
            return data;
        }
        public List<NHANVIEN> getnhanvien()
        {

            var data = (from dt in ql.NHANVIENs select dt).ToList();
            return data;
        }
        public List<VAITRO> getvt()
        {

            var data = (from dt in ql.VAITROs select dt).ToList();
            return data;
        }
        public bool themNV(NHANVIEN n)
        {
            try
            {
                n.MANV = ql.NHANVIENs.Max(x => x.MANV) + 1;
                ql.NHANVIENs.InsertOnSubmit(n);
                ql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool xoaNV(int manv)
        {
            try
            {
                NHANVIEN k = ql.NHANVIENs.Where(t => t.MANV == manv).FirstOrDefault();
                ql.NHANVIENs.DeleteOnSubmit(k);
                ql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool suaNV(int ma, string ten, string mail, string sdt, string tdn, string mk,int mavt)
        {
            try
            {
                NHANVIEN k = ql.NHANVIENs.Where(t => t.MANV == ma).FirstOrDefault();
                k.TENNV = ten;
                k.EMAIL = mail;
                k.SDT = sdt;
                k.TENDANGNHAP = tdn;
                k.MATKHAU = mk;
                k.MAVT = mavt;
                ql.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }


        }
    }
}
