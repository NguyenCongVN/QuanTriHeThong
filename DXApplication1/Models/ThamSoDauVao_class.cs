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
        private double x_water;
        private double y_water;
        private double x_wind;
        private double y_wind;
        private double upward_sea;
        private double sign_height;
        private double drift_x;
        private double drift_y;
        private double temperature;
        private double salinity;
        private int idLoaiDau;
        private int vitri_x;
        private int vitr_y;
        private double luongdau;
        private DateTime thoigian;

        //public ThamSoDauVao_class(int mathamso, double x_water, double y_water, double x_wind, double y_wind, double upward_sea, double sign_height, double drift_x, double drift_y, double temperature, double salinity, int idLoaiDau, int vitri_x, int vitr_y, double luongdau, DateTime thoigian)
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
        public double X_water { get => x_water; set => x_water = value; }
        public double Y_water { get => y_water; set => y_water = value; }
        public double X_wind { get => x_wind; set => x_wind = value; }
        public double Y_wind { get => y_wind; set => y_wind = value; }
        public double Upward_sea { get => upward_sea; set => upward_sea = value; }
        public double Sign_height { get => sign_height; set => sign_height = value; }
        public double Drift_x { get => drift_x; set => drift_x = value; }
        public double Drift_y { get => drift_y; set => drift_y = value; }
        public double Temperature { get => temperature; set => temperature = value; }
        public double Salinity { get => salinity; set => salinity = value; }
        public int IdLoaiDau { get => idLoaiDau; set => idLoaiDau = value; }
        public int Vitri_x { get => vitri_x; set => vitri_x = value; }
        public int Vitr_y { get => vitr_y; set => vitr_y = value; }
        public double Luongdau { get => luongdau; set => luongdau = value; }
        public DateTime Thoigian { get => thoigian; set => thoigian = value; }
    }
}
