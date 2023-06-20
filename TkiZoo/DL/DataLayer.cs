using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TkiZoo.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder() 
            {
                Server = "127.0.0.1" ,
                Database = "tki_zoo" ,
                UserID = "root" ,
                Password = "zx.wp.1." ,
            
            }.ConnectionString
         );
        public static int MusteriEkle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_MusteriEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soyad", m.Soyad);
                komut.Parameters.AddWithValue("@yas", m.Yas);
                komut.Parameters.AddWithValue("@cinsiyet", m.Cinsiyet);
                komut.Parameters.AddWithValue("@ziyaret", m.Ziyaret);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
           
        }

        internal static int MusteriSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_MusteriSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



        internal static int MusteriGuncelle(Musteri m)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_MusteriGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soyad", m.Soyad);
                komut.Parameters.AddWithValue("@yas", m.Yas);
                komut.Parameters.AddWithValue("@cinsiyet", m.Cinsiyet);
                komut.Parameters.AddWithValue("@ziyaret", m.Ziyaret);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int HayvanSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_HayvanSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int BakiciSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_BakiciSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {

                    komut = new MySqlCommand("tki_MusteriHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    
                }
                else 
                {
                    komut = new MySqlCommand("tki_MusteriBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int HayvanEkle(Hayvan h)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_HayvanEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", h.ID);
                komut.Parameters.AddWithValue("@ad", h.Ad);
                komut.Parameters.AddWithValue("@tur", h.Tur);
                komut.Parameters.AddWithValue("@yas", h.Yas);
                komut.Parameters.AddWithValue("@cinsiyet", h.Cinsiyet);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
        internal static DataSet HayvanGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {

                    komut = new MySqlCommand("tki_HayvanHepsi", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;


                }
                else
                {
                    komut = new MySqlCommand("tki_HayvanBul", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
        internal static int HayvanGuncelle(Hayvan h)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_HayvanGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", h.ID);
                komut.Parameters.AddWithValue("@ad", h.Ad);
                komut.Parameters.AddWithValue("@tur", h.Tur);
                komut.Parameters.AddWithValue("@yas", h.Yas);
                komut.Parameters.AddWithValue("@cinsiyet", h.Cinsiyet);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int BakiciEkle(Bakici b)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_BakiciEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@bid", b.ID);
                komut.Parameters.AddWithValue("@hid", b.HayvanID);
                komut.Parameters.AddWithValue("@ad", b.Ad);
                komut.Parameters.AddWithValue("@soyad", b.Soyad);
                komut.Parameters.AddWithValue("@yas", b.Yas);
                komut.Parameters.AddWithValue("@Cinsiyet", b.Cinsiyet);
                komut.Parameters.AddWithValue("@telefon", b.Telefon);
                komut.Parameters.AddWithValue("@hayvan", b.Bakilan);


                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet BakiciDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut  = new MySqlCommand("tki_BakiciDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int BakiciGuncelle(Bakici b)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_BakiciGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@bid", b.ID);
                komut.Parameters.AddWithValue("@hid", b.HayvanID);
                komut.Parameters.AddWithValue("@ad", b.Ad);
                komut.Parameters.AddWithValue("@soyad", b.Soyad);
                komut.Parameters.AddWithValue("@yas", b.Yas);
                komut.Parameters.AddWithValue("@Cinsiyet", b.Cinsiyet);
                komut.Parameters.AddWithValue("@telefon", b.Telefon);
                komut.Parameters.AddWithValue("@hayvan", b.Bakilan);

                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdemeEkle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_OdemeEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.OdemeTur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);


                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static DataSet OdemeDetay()
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_OdemeDetay", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);

                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int OdemeGuncelle(Odeme o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_OdemeGuncelle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", o.ID);
                komut.Parameters.AddWithValue("@mid", o.MusteriID);
                komut.Parameters.AddWithValue("@tarih", o.Tarih);
                komut.Parameters.AddWithValue("@tutar", o.Tutar);
                komut.Parameters.AddWithValue("@tur", o.OdemeTur);
                komut.Parameters.AddWithValue("@aciklama", o.Aciklama);


                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }


        internal static int OdemeSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                MySqlCommand komut = new MySqlCommand("tki_OdemeSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@oid", id);


                int res = komut.ExecuteNonQuery();
                return res;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }



    }
}
