using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DXApplication1.Models
{
    class BanDoSql : ConnectionDatabase
    {
        enum BanDoField
        {
            MaBanDo,
            TenBanDo,
            DuongDanAnh
        }
        public List<BanDo> Select_All_Map()
        {
            SqlCommand command = new SqlCommand("SelectAllMap", Connection);
            command.CommandType = CommandType.StoredProcedure;
            try
            {
                Connection.Open();
                List<BanDo> list = new List<BanDo>();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    foreach (DataRow row in table.Rows)
                    {
                        list.Add(new BanDo()
                        {
                            MaBanDo = row.Field<int>((int)BanDoField.MaBanDo),
                            DuongDanAnh = row.Field<string>((int)BanDoField.DuongDanAnh),
                            TenBanDo = row.Field<string>((int)BanDoField.TenBanDo)
                        });
                    }
                }
                return list;
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("Map::Select Map::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }

        public void CreateMap(BanDo banDo)
        {
            SqlCommand command = new SqlCommand("CreateMap", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TenBanDo", banDo.TenBanDo);
            command.Parameters.AddWithValue("@DuongDanAnh", banDo.DuongDanAnh);
            try
            {
                Connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("Map::Create Map::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }

        public void UpdateMap(BanDo banDo)
        {
            SqlCommand command = new SqlCommand("UpdateMap", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TenBanDo", banDo.TenBanDo);
            command.Parameters.AddWithValue("@DuongDanAnh", banDo.DuongDanAnh);
            command.Parameters.AddWithValue("@MaBanDo", banDo.MaBanDo);
            try
            {
                Connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("Map::Update Map::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }


        public void DeleteMap(int maBanDo)
        {
            SqlCommand command = new SqlCommand("DeleteMap", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@maBanDo", maBanDo);
            try
            {
                Connection.Open();
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Connection.Close();
                command.Dispose();
                throw new Exception("Map::Delete Map::Error occured.", ex);
            }
            finally
            {
                Connection.Close();
                command.Dispose();
            }
        }
    }
}
