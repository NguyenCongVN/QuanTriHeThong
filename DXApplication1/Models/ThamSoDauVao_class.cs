using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1.Models
{
    public class ThamSoDauVao_class
    {
        private int mathamso;
        private float x_water;
        private float y_water;
        private float x_wind;
        private float y_wind;
        private float upward_sea;
        private float sign_height;
        private float drift_x;
        private float drift_y;
        private float temperature;
        private float salinity;
        private int idLoaiDau;
        private int vitri_x;
        private int vitr_y;
        private float luongdau;
        private DateTime thoigian;

        //public ThamSoDauVao_class(int mathamso, float x_water, float y_water, float x_wind, float y_wind, float upward_sea, float sign_height, float drift_x, float drift_y, float temperature, float salinity, int idLoaiDau, int vitri_x, int vitr_y, float luongdau, DateTime thoigian)
        //{
        //    this.mathamso = mathamso;
        //    this.x_water = x_water;
        //    this.y_water = y_water;
        //    this.x_wind = x_wind;
        //    this.y_wind = y_wind;
        //    this.upward_sea = upward_sea;
        //    this.sign_height = sign_height;
        //    this.drift_x = drift_x;
        //    this.drift_y = drift_y;
        //    this.temperature = temperature;
        //    this.salinity = salinity;
        //    this.idLoaiDau = idLoaiDau;
        //    this.vitri_x = vitri_x;
        //    this.vitr_y = vitr_y;
        //    this.luongdau = luongdau;
        //    this.thoigian = thoigian;
        //}

        public int Mathamso { get => mathamso; set => mathamso = value; }
        public float X_water { get => x_water; set => x_water = value; }
        public float Y_water { get => y_water; set => y_water = value; }
        public float X_wind { get => x_wind; set => x_wind = value; }
        public float Y_wind { get => y_wind; set => y_wind = value; }
        public float Upward_sea { get => upward_sea; set => upward_sea = value; }
        public float Sign_height { get => sign_height; set => sign_height = value; }
        public float Drift_x { get => drift_x; set => drift_x = value; }
        public float Drift_y { get => drift_y; set => drift_y = value; }
        public float Temperature { get => temperature; set => temperature = value; }
        public float Salinity { get => salinity; set => salinity = value; }
        public int IdLoaiDau { get => idLoaiDau; set => idLoaiDau = value; }
        public int Vitri_x { get => vitri_x; set => vitri_x = value; }
        public int Vitr_y { get => vitr_y; set => vitr_y = value; }
        public float Luongdau { get => luongdau; set => luongdau = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
    }
}
