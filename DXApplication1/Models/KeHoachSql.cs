using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DevExpress.DataProcessing;

namespace DXApplication1.Models
{
    class KeHoachSql : ConnectionDatabase
    {
        enum FieldKeHoach
        {
            MaKeHoach,
            TenKeHoach,
            HoTen,
            ThoiGianTao,
            MaDangNhapNguoiDung
        }

        enum FieldKeHoachBanDoFileDem
        {
            MaKeHoach,
            TenKeHoach,
            HoTen,
            MaDangNhapNguoiDung,
            ThoiGianTao,
            MaBanDo,
            TenBanDo,
            DuongDanAnh,
            TenFile,
            DuongDanFile,
            MaFile,
            ChieuRong,
            ChieuDai
        }
        public void ThemKeHoach(KeHoach keHoach)
        {
            SqlCommand sqlCommand = new SqlCommand("ThemKeHoach", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            Connection.Open();
            sqlCommand.Parameters.AddWithValue("@name", keHoach.TenKeHoach);
            sqlCommand.Parameters.AddWithValue("@maNguoiLapKeHoach", keHoach.MaNguoiLap);
            keHoach.MaKeHoach = (int)sqlCommand.ExecuteScalar();
            Connection.Close();
        }

        public List<KeHoach> GetAllKeHoach()
        {
            SqlCommand sqlCommand = new SqlCommand("GetAllKeHoach", Connection);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            List<KeHoach> keHoaches = new List<KeHoach>();
            Connection.Open();
            using (SqlDataAdapter adpAdapter = new SqlDataAdapter(sqlCommand))
            {
                DataTable table = new DataTable();
                adpAdapter.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    keHoaches.Add(new KeHoach()
                    {
                        MaNguoiLap = row.Field<string>((int)FieldKeHoach.MaDangNhapNguoiDung),
                        MaKeHoach = row.Field<int>((int)FieldKeHoach.MaKeHoach),
                        TenKeHoach = row.Field<string>((int)FieldKeHoach.TenKeHoach),
                        TenNguoiLap = row.Field<string>((int)FieldKeHoach.HoTen),
                        ThoiGianTao = row.Field<DateTime>((int)FieldKeHoach.ThoiGianTao),
                    });
                }
            }
            Connection.Close();
            return keHoaches;
        }

        public KeHoach GetKeHoachById(int maKeHoach)
        {
            SqlCommand sqlCommand = new SqlCommand("LayKeHoachBangMa", Connection);
            sqlCommand.Parameters.AddWithValue("@maKeHoach", maKeHoach);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            Connection.Open();
            KeHoach keHoach;
            using (SqlDataAdapter adpAdapter = new SqlDataAdapter(sqlCommand))
            {
                DataTable table = new DataTable();
                adpAdapter.Fill(table);
                keHoach = new KeHoach()
                {
                    MaNguoiLap = table.Rows[0].Field<string>((int)FieldKeHoach.MaDangNhapNguoiDung),
                    MaKeHoach = table.Rows[0].Field<int>((int)FieldKeHoach.MaKeHoach),
                    TenKeHoach = table.Rows[0].Field<string>((int)FieldKeHoach.TenKeHoach),
                    TenNguoiLap = table.Rows[0].Field<string>((int)FieldKeHoach.HoTen),
                    ThoiGianTao = table.Rows[0].Field<DateTime>((int)FieldKeHoach.ThoiGianTao),
                };
            }
            Connection.Close();
            return keHoach;
        }

        public KeHoach GetKeHoachAndDetailById(int maKeHoach)
        {
            SqlCommand sqlCommand = new SqlCommand("LayKeHoachBanDoFileBangMa", Connection);
            sqlCommand.Parameters.AddWithValue("@maKeHoach", maKeHoach);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            Connection.Open();
            KeHoach keHoach;
            using (SqlDataAdapter adpAdapter = new SqlDataAdapter(sqlCommand))
            {
                DataTable table = new DataTable();
                adpAdapter.Fill(table);
                keHoach = new KeHoach()
                {
                    MaNguoiLap = table.Rows[0].Field<string>((int)FieldKeHoachBanDoFileDem.MaDangNhapNguoiDung),
                    MaKeHoach = table.Rows[0].Field<int>((int)FieldKeHoachBanDoFileDem.MaKeHoach),
                    TenKeHoach = table.Rows[0].Field<string>((int)FieldKeHoachBanDoFileDem.TenKeHoach),
                    TenNguoiLap = table.Rows[0].Field<string>((int)FieldKeHoachBanDoFileDem.HoTen),
                    ThoiGianTao = table.Rows[0].Field<DateTime>((int)FieldKeHoachBanDoFileDem.ThoiGianTao),
                    
                };
                if (table.Rows[0][((int) FieldKeHoachBanDoFileDem.MaBanDo)] != DBNull.Value)
                {
                    keHoach.BanDo = new BanDo()
                    {
                        MaBanDo = table.Rows[0].Field<int>((int) FieldKeHoachBanDoFileDem.MaBanDo),
                        TenBanDo = table.Rows[0].Field<string>((int) FieldKeHoachBanDoFileDem.TenBanDo),
                        DuongDanAnh = table.Rows[0].Field<string>((int) FieldKeHoachBanDoFileDem.DuongDanAnh)
                    };
                }

                if (table.Rows[0][((int) FieldKeHoachBanDoFileDem.MaFile)] != DBNull.Value)
                {
                    keHoach.FileDem = new Dem()
                    {
                        MaFile = table.Rows[0].Field<int>((int) FieldKeHoachBanDoFileDem.MaFile),
                        TenFile = table.Rows[0].Field<string>((int) FieldKeHoachBanDoFileDem.TenFile),
                        DuongDan = table.Rows[0].Field<string>((int) FieldKeHoachBanDoFileDem.DuongDanFile)
                    };
                }
            }
            Connection.Close();
            return keHoach;
        }
    }
}
