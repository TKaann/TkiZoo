using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TkiZoo.DL;

namespace TkiZoo.BL
{
    public static class BLogic
    {

        public static bool MusteriEkle(Musteri m) 
        {
            try
            {
                int res = DataLayer.MusteriEkle(m);
                return (res > 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }
        }

        internal static bool MusteriGuncelle(Musteri m)
        {
            try
            {
                int res = DataLayer.MusteriGuncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }

        }


        internal static bool MusteriSil(string id)
        {
            try
            {
                int res = DataLayer.MusteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }

        }


        internal static bool HayvanEkle(Hayvan h)
        {
            try
            {
                int res = DataLayer.HayvanEkle(h);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet HayvanGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.HayvanGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }
        }

        internal static bool HayvanGuncelle(Hayvan h)
        {
            try
            {
                int res = DataLayer.HayvanGuncelle(h);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }



        internal static bool HayvanSil(string id)
        {
            try
            {
                int res = DataLayer.HayvanSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool BakiciEkle(Bakici b)
        {
            try
            {
                int res = DataLayer.BakiciEkle(b);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet BakiciDetay()
        {
            try
            {
                DataSet ds = DataLayer.BakiciDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }
        }

        internal static bool BakiciSil(string id)
        {
            try
            {
                int res = DataLayer.BakiciSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool BakiciGuncelle(Bakici b)
        {
            try
            {
                int res = DataLayer.BakiciGuncelle(b);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeEkle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeEkle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                DataSet ds = DataLayer.OdemeDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return null;
            }
        }

        internal static bool OdemeGuncelle(Odeme o)
        {
            try
            {
                int res = DataLayer.OdemeGuncelle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }
        }

        internal static bool OdemeSil(string id)
        {
            try
            {
                int res = DataLayer.OdemeSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Olustu" + ex.Message);
                return false;
            }

        }
    }
}
