using System;

namespace PTZRv2
{
	/// <summary>
	/// Hold Addresses of modbus address space
	/// </summary>
	public sealed class CMbAddr
	{
		public CMbAddr()
		{
			
		}
		public static ushort _CountImp_ul =120;
		
		public static ushort _CorrectFlow_ul		= 122;
		public static ushort _NotCorrectFlow_ul = 124;
	

		public static ushort _PVPressure_flt = 126; 
		public static ushort _PVTemp_si =128; 

		public static ushort _PRb_flt = 129;
		public static ushort _PRe_flt = 131;

		public static ushort _year = 135;
		public static ushort _month = 136; 
		public static ushort _date = 137; 
		public static ushort _hour = 138; 
		public static ushort _minute = 139; 
		public static ushort _second = 140; 

		public static ushort _val_0 = 141; 
		public static ushort _val_1 = 142; 
		public static ushort _TypeTempInput = 143; 
		public static ushort _PXb_ui = 144; 
		public static ushort _PXe_ui = 145; 

    public static ushort _PVResis = 148; //-10
    public static ushort _TempCorection_fl = 150;

		public static ushort _TX_ui_0 = 146; //-10
		public static ushort _TX_ui_1 = 147; //0
		public static ushort _TX_ui_2 = 148; //10
		public static ushort _TX_ui_3 = 149; //20
		public static ushort _TX_ui_4 = 150; //30
		public static ushort _TX_ui_5 = 151; //40
		public static ushort _TX_ui_6 = 152; //50

		public static ushort _Tbase_flt = 153; //Bazova Temperatura za Bulgaria in Kelvins 293.15K
		public static ushort _Pbase_flt = 155; //Bazovo naliagane po temperatura(1.01325)bar
		public static ushort _Zbase_flt = 157; //Koeficient na svryh svivaemost pri bazovi usloviq
		
		public static ushort _Const_flt = 159;//Constanta na razhodomera. Kolko m3 za 1 impuls 

		public static ushort _Z_flt = 161;//Izchislenata Svryh svivaemost
		public static ushort _CorrectFlow_flt = 163;//Korigiran razhod sled desitichnata tochka


		public static ushort _BackUp_CorrectFlow_ul = 165;
		public static ushort _BackUp_CountImp_ul = 171;

		public static ushort _SerialNumber_ul = 177;
		public static ushort _flCover = 179;
		public static ushort _CorrectionCoefitient = 180;

		public static ushort _PVTempK_flt = 182;

		public static ushort _UsePressureInput_uc = 184;
		public static ushort _PressureWhenNotMeasure_flt = 185;

    public static ushort _HighLimitPress_flt = 187;
    public static ushort _LowLimitPress_flt = 189; 

    public static ushort  _HighLimit_flLimit =  191;
    public static ushort  _LowLimit_flLimit =   192;
                               
    public static ushort  _HighLimit_month =    193;
    public static ushort  _HighLimit_date =     194;
    public static ushort  _HighLimit_hour =     195;
    public static ushort  _HighLimit_minute =   196;
                               
    public static ushort  _LowLimit_month =     197;
    public static ushort  _LowLimit_date =      198;
    public static ushort  _LowLimit_hour =      199;
    public static ushort  _eeLowLimit_minute =  200;

    public static ushort  _MohthArj_uc =  201;
    public static ushort  _HourArj_uc  =  202;


	
		public static ushort[,] _Compress_flt = new ushort[3,7]  
		{
			{500, 502,504,506,508,510,512},
			{600, 602,604,606,608,610,612},
			{700, 702,704,706,708,710,712},
		};

		/*public static int[,] _Compress_flt = new int[3,5]  
		{
			{500, 600, 700},
			{502, 602, 702},
			{504, 604, 704},
			{506, 606, 706},
			{508, 608, 708},
		};*/

	}
}
