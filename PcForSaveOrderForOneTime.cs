﻿using jenya_lab_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jenya_lab_7
{
    public static class PcForSaveOrderForOneTime
    {
        public static string idCpu;
        public static string Cpu;

        public static string idHdd;
        public static string Hdd;

        public static string idPopwerSupply;
        public static string popwerSupply;

        public static string idRam;
        public static string ram;

        public static string idSsd;
        public static string ssd;

        public static string idBluetooth;
        public static string bluetooth;

        public static string idGpu;
        public static string gpu;

        public static string idFanCooling;
        public static string fanCooling;

        public static string idWifi;
        public static string wifi;

        public static string idMotherboard;
        public static string motherboard;

        public static string idWaterCooling;
        public static string waterCooling;

        public static string idTower;
        public static string tower;

        public static void ClearAll()
        {
            // Очищення CPU
            idCpu = null;
            Cpu = null;

            // Очищення HDD
            idHdd = null;
            Hdd = null;

            // Очищення блоку живлення
            idPopwerSupply = null;
            popwerSupply = null;

            // Очищення RAM
            idRam = null;
            ram = null;

            // Очищення SSD
            idSsd = null;
            ssd = null;

            // Очищення Bluetooth
            idBluetooth = null;
            bluetooth = null;

            // Очищення GPU
            idGpu = null;
            gpu = null;

            // Очищення вентиляторного охолодження
            idFanCooling = null;
            fanCooling = null;

            // Очищення Wi-Fi
            idWifi = null;
            wifi = null;

            // Очищення материнської плати
            idMotherboard = null;
            motherboard = null;

            // Очищення водяного охолодження
            idWaterCooling = null;
            waterCooling = null;

            // Очищення корпусу
            idTower = null;
            tower = null;
        }

    } 

}



