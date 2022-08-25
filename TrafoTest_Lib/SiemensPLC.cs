using System;
using System.Management.Instrumentation;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using TrafoTest_Model.Model;
using TrafoTest_Model.Arizalar;
using System.Net.Mail;

namespace TrafoTest_Lib
{
    public static class PlcTag
    {
        public static bool IsDemoMod { get; set; } = false;
        public static List<string> mailList { get; set; }

        public static int Db_tank1ToplamKalanSure { get; set; } = 0;
        public static int Db_tank2ToplamKalanSure { get; set; } = 0;
        public static int Db_tank3ToplamKalanSure { get; set; } = 0;
        public static int Db_tank4ToplamKalanSure { get; set; } = 0;

        public static int Db_tank1ToplamSure { get; set; } = 0;
        public static int Db_tank2ToplamSure { get; set; } = 0;
        public static int Db_tank3ToplamSure { get; set; } = 0;
        public static int Db_tank4ToplamSure { get; set; } = 0;

        public static int Db_tank1_IslemDurumu { get; set; } = 0;
        public static int Db_tank2_IslemDurumu { get; set; } = 0;
        public static int Db_tank3_IslemDurumu { get; set; } = 0;
        public static int Db_tank4_IslemDurumu { get; set; } = 0;

        public static bool DB_tank1_TepeLambasiKirmizi { get; set; } = false;
        public static bool DB_tank1_TepeLambasiSari { get; set; } = false;
        public static bool DB_tank1_TepeLambasiYesil { get; set; } = false;

        public static bool DB_tank2_TepeLambasiKirmizi { get; set; } = false;
        public static bool DB_tank2_TepeLambasiSari { get; set; } = false;
        public static bool DB_tank2_TepeLambasiYesil { get; set; } = false;

        public static bool DB_tank3_TepeLambasiKirmizi { get; set; } = false;
        public static bool DB_tank3_TepeLambasiSari { get; set; } = false;
        public static bool DB_tank3_TepeLambasiYesil { get; set; } = false;

        public static bool DB_tank4_TepeLambasiKirmizi { get; set; } = false;
        public static bool DB_tank4_TepeLambasiYesil { get; set; } = false;
        public static bool DB_tank4_TepeLambasiSari { get; set; } = false;

        public static bool islemBaslatiliyor { get; set; } = false;


        #region Kullanilanlar

        public static int Db_tank1AlarmWord_Old { get; set; } //local alarm 1
        public static int Db_tank2AlarmWord_Old { get; set; } //local alarm 2
        public static int Db_tank3AlarmWord_Old { get; set; } //local alarm 3
        public static int Db_tank4AlarmWord_Old { get; set; } //local alarm 4
        public static int Db_genelAlarmWord_Old { get; set; } //Genel alarm

        // Tank Gosterge iki tane kırmızı - yeşil butonun baktığı veri
        public static bool DB_tank1_VakumValfi { get; set; }
        public static bool DB_tank1_TahliyeValfi { get; set; }
        public static bool DB_tank2_VakumValfi { get; set; }
        public static bool DB_tank2_TahliyeValfi { get; set; }
        public static bool DB_tank3_VakumValfi { get; set; }
        public static bool DB_tank3_TahliyeValfi { get; set; }
        public static bool DB_tank4_VakumValfi { get; set; }
        public static bool DB_tank4_TahliyeValfi { get; set; }

        // PLC İNTEGER VERİLERİ db1.dbw4- db1.dbw68 ARASINDADIR
        public static int Db_tank1AlarmWord { get; set; }     //db1.dbw4 - int00
        public static int Db_tank2AlarmWord { get; set; }     //db1.dbw6 - int01
        public static int Db_tank3AlarmWord { get; set; }     //db1.dbw8 - int02
        public static int Db_tank4AlarmWord { get; set; }     //db1.dbw10 - int03
        public static int Db_genelAlarmWord { get; set; }     //db1.dbw12 - int04

        public static int Db_tank1IslemAdim { get; set; }     //db1.dbw14 - int05
        public static int Db_tank1ProsesAdim { get; set; }    //db1.dbw16 - int06
        public static int Db_tank1CalismaZamani { get; set; } //db1.dbw18 - int07

        public static int Db_tank2IslemAdim { get; set; }     //db1.dbw20 - int08
        public static int Db_tank2ProsesAdim { get; set; }    //db1.dbw22 - int09
        public static int Db_tank2CalismaZamani { get; set; } //db1.dbw24 - int10

        public static int Db_tank3IslemAdim { get; set; }     //db1.dbw26 - int11
        public static int Db_tank3ProsesAdim { get; set; }    //db1.dbw28 - int12
        public static int Db_tank3CalismaZamani { get; set; } //db1.dbw30 - int13

        public static int Db_tank4IslemAdim { get; set; }     //db1.dbw32 - int14
        public static int Db_tank4ProsesAdim { get; set; }    //db1.dbw34 - int15
        public static int Db_tank4CalismaZamani { get; set; } //db1.dbw36 - int16

        // PLC REAL VERİLERİ db1.dbd70- db1.dbd198 ARASINDADIR
        public static float Db_kazan1Sicaklik1 { get; set; } //db1.dbd70  - real00 
        public static float Db_kazan1Sicaklik2 { get; set; } //db1.dbd74  - real01
        public static float Db_kazan1Sicaklik3 { get; set; } //db1.dbw78  - real02
        public static float Db_kazan1Sicaklik4 { get; set; } //db1.dbw142 - real18
        public static float Db_kazan1Sicaklik5 { get; set; } //db1.dbw146 - real19

        public static float Db_kazan2Sicaklik1 { get; set; } //db1.dbw82   - real03
        public static float Db_kazan2Sicaklik2 { get; set; } //db1.dbw86   - real04
        public static float Db_kazan2Sicaklik3 { get; set; } //db1.dbw90   - real05
        public static float Db_kazan2Sicaklik4 { get; set; } //db1.dbw150  - real20
        public static float Db_kazan2Sicaklik5 { get; set; } //db1.dbw154  - real21

        public static float Db_kazan3Sicaklik1 { get; set; } //db1.dbw94   - real06
        public static float Db_kazan3Sicaklik2 { get; set; } //db1.dbw98   - real07
        public static float Db_kazan3Sicaklik3 { get; set; } //db1.dbw102  - real08
        public static float Db_kazan3Sicaklik4 { get; set; } //db1.dbw158  - real22
        public static float Db_kazan3Sicaklik5 { get; set; } //db1.dbw162  - real23

        public static float Db_kazan4Sicaklik1 { get; set; } //db1.dbw106  - real09
        public static float Db_kazan4Sicaklik2 { get; set; } //db1.dbw110  - real10
        public static float Db_kazan4Sicaklik3 { get; set; } //db1.dbw114  - real11
        public static float Db_kazan4Sicaklik4 { get; set; } //db1.dbw166  - real24
        public static float Db_kazan4Sicaklik5 { get; set; } //db1.dbw170  - real25

        public static float Db_kazan12OrtakVakum { get; set; } //db1.dbw118 - real12
        public static float Db_kazan34OrtakVakum { get; set; } //db1.dbw122 - real13

        public static float Db_kazan1Vakum { get; set; } //db1.dbw126 - real14
        public static float Db_kazan2Vakum { get; set; } //db1.dbw130 - real15
        public static float Db_kazan3Vakum { get; set; } //db1.dbw134 - real16
        public static float Db_kazan4Vakum { get; set; } //db1.dbw138 - real17

        // PLC BYTE VERİLERİ db1.dbb0- db1.dbb3 ARASINDADIR
        public static byte Db_KontrolByte00 { get; set; } //db1.dbb0
        public static byte Db_KontrolByte01 { get; set; } //db1.dbb1

        public static byte Byte00 { get; set; } //db1.dbb202
        public static byte Byte01 { get; set; } //db1.dbb203
        public static byte Byte02 { get; set; } //db1.dbb204
        public static byte Byte03 { get; set; } //db1.dbb205
        public static byte Byte04 { get; set; } //db1.dbb206
        public static byte Byte05 { get; set; } //db1.dbb207
        public static byte Byte06 { get; set; } //db1.dbb208
        public static byte Byte07 { get; set; } //db1.dbb209
        public static byte Byte08 { get; set; } //db1.dbb210
        public static byte Byte09 { get; set; } //db1.dbb211


        // PLC IO BYTE VERİLERİ db9.dbb0- db9.dbb8 ARASINDADIR
        public static byte Db_InputByte00 { get; set; }  //db9.dbb0
        public static byte Db_InputByte01 { get; set; }  //db9.dbb1
        public static byte Db_InputByte02 { get; set; }  //db9.dbb2
        public static byte Db_InputByte03 { get; set; }  //db9.dbb3
        public static byte Db_OutputByte00 { get; set; } //db9.dbb4
        public static byte Db_OutputByte01 { get; set; } //db9.dbb5
        public static byte Db_OutputByte02 { get; set; } //db9.dbb6
        public static byte Db_OutputByte03 { get; set; } //db9.dbb7
        public static byte Db_OutputByte04 { get; set; } //db9.dbb8

        #endregion

        #region Kullanilmayanlar
        // PLC İNTEGER VERİLERİ db1.dbw4- db1.dbw68 ARASINDADIR
        public static int Db_Yedek_Int04 { get; set; } //db1.dbw46 - int21
        public static int Db_Yedek_Int05 { get; set; } //db1.dbw48 - int22
        public static int Db_Yedek_Int06 { get; set; } //db1.dbw50 - int23
        public static int Db_Yedek_Int07 { get; set; } //db1.dbw52 - int24
        public static int Db_Yedek_Int08 { get; set; } //db1.dbw54 - int25
        public static int Db_Yedek_Int09 { get; set; } //db1.dbw56 - int26
        public static int Db_Yedek_Int10 { get; set; } //db1.dbw58 - int27
        public static int Db_Yedek_Int11 { get; set; } //db1.dbw60 - int28

        //SCADA tarafından yazılan datalar okuma yapılmadıgı için kullanılmadı
        public static int Db_Kazan1ReceteAdim { get; set; } //db1.dbw62 - int29 
        public static int Db_Kazan2ReceteAdim { get; set; } //db1.dbw64 - int30
        public static int Db_Kazan3ReceteAdim { get; set; } //db1.dbw66 - int31
        public static int Db_Kazan4ReceteAdim { get; set; } //db1.dbw68 - int32

        //PLC BOOL Tagları db1.dbx0.0- db1.dbx2.7 ARASINDADIR
        public static bool Db_Yedek_Bool00 { get; set; } // db1.dbx1.5
        public static bool Db_Yedek_Bool01 { get; set; } // db1.dbx1.6
        public static bool Db_Yedek_Bool02 { get; set; } // db1.dbx1.7
        public static bool Db_Yedek_Bool03 { get; set; } // db1.dbx2.0
        public static bool Db_Yedek_Bool04 { get; set; } // db1.dbx2.1
        public static bool Db_Yedek_Bool05 { get; set; } // db1.dbx2.2
        public static bool Db_Yedek_Bool06 { get; set; } // db1.dbx2.3
        public static bool Db_Yedek_Bool07 { get; set; } // db1.dbx2.4
        public static bool Db_Yedek_Bool08 { get; set; } // db1.dbx2.5
        public static bool Db_Yedek_Bool09 { get; set; } // db1.dbx2.6
        public static bool Db_Yedek_Bool10 { get; set; } // db1.dbx2.7
        #endregion
    }

    public class PLC
    {
        static libnodave.daveOSserialType fds;
        static libnodave.daveInterface di;
        static libnodave.daveConnection dc;

        public static int res;

        static int rack = 0;
        static int slot = 1;

        public static bool Connection { get; set; } = false;

        static byte[] memoryBuffer = new byte[100];
        static byte[] buffer = new Byte[100];
        static byte[] Vout = new Byte[100];

        public static bool Connect(string Ip = "")
        {
            try
            {
                fds.rfd = libnodave.openSocket(102, Ip);
                fds.wfd = fds.rfd;

                if (fds.rfd > 0)
                {
                    di = new libnodave.daveInterface(fds, "IF1", 0, libnodave.daveProtoISOTCP, libnodave.daveSpeed187k);
                    di.setTimeout(100);
                    res = di.initAdapter(); // does nothing in ISO_TCP. But call it to keep your programs indpendent of protocols
                    if (res == 0)
                    {
                        dc = new libnodave.daveConnection(di, 0, rack, slot);
                        if (0 == dc.connectPLC())
                        {
                            Connection = true;
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Hata " + res + " " + libnodave.daveStrerror(res));
                            Connection = false;
                            return false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Does nothing in ISO_TCP. " + Ip.ToString());
                        Connection = false;
                        return false;
                    }
                }
                else
                {
                    libnodave.closeSocket(fds.rfd);
                    //MessageBox.Show("TCP Bağlantısı Açılamadı  : " + Ip.ToString());
                    Connection = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                di.disconnectAdapter();
                Connection = false;
                return false;
            }
        }
        public static bool Disconnect()
        {
            try
            {
                dc.disconnectPLC();
                Connection = false;
                return true;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        public static bool IsBitSet(byte b, int pos)
        {
            return (b & (1 << pos)) != 0;
        }
        public static bool ReadByteIo(int db, int adres, int uzunluk)
        {
            if (Connection == true)
            {
                res = dc.readBytes(libnodave.daveDB, db, adres, uzunluk, memoryBuffer);//GIRIS CIKIS DURUMLARI OKUNUYOR
                if (res == 0)
                {
                    PlcTag.Db_InputByte00 = memoryBuffer[0];
                    PlcTag.Db_InputByte01 = memoryBuffer[1];
                    PlcTag.Db_InputByte02 = memoryBuffer[2];
                    PlcTag.Db_InputByte03 = memoryBuffer[3];
                    PlcTag.Db_OutputByte00 = memoryBuffer[4];
                    PlcTag.Db_OutputByte01 = memoryBuffer[5];
                    PlcTag.Db_OutputByte02 = memoryBuffer[6];
                    PlcTag.Db_OutputByte03 = memoryBuffer[7];
                    PlcTag.Db_OutputByte04 = memoryBuffer[8];

                    //Vakum ve tahliye valflerini ana ekrana tasıma
                    if (IsBitSet(PlcTag.Db_OutputByte02, 0)) { PlcTag.DB_tank1_VakumValfi = true; } else { PlcTag.DB_tank1_VakumValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 1)) { PlcTag.DB_tank2_VakumValfi = true; } else { PlcTag.DB_tank2_VakumValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 2)) { PlcTag.DB_tank3_VakumValfi = true; } else { PlcTag.DB_tank3_VakumValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 3)) { PlcTag.DB_tank4_VakumValfi = true; } else { PlcTag.DB_tank4_VakumValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 4)) { PlcTag.DB_tank1_TahliyeValfi = true; } else { PlcTag.DB_tank1_TahliyeValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 5)) { PlcTag.DB_tank2_TahliyeValfi = true; } else { PlcTag.DB_tank2_TahliyeValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 6)) { PlcTag.DB_tank3_TahliyeValfi = true; } else { PlcTag.DB_tank3_TahliyeValfi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte02, 7)) { PlcTag.DB_tank4_TahliyeValfi = true; } else { PlcTag.DB_tank4_TahliyeValfi = false; }

                    //Tepe Lambası Durumları
                    if (IsBitSet(PlcTag.Db_OutputByte03, 0)) { PlcTag.DB_tank1_TepeLambasiKirmizi = true; } else { PlcTag.DB_tank1_TepeLambasiKirmizi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 1)) { PlcTag.DB_tank1_TepeLambasiSari = true; } else { PlcTag.DB_tank1_TepeLambasiSari = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 2)) { PlcTag.DB_tank1_TepeLambasiYesil = true; } else { PlcTag.DB_tank1_TepeLambasiYesil = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 3)) { PlcTag.DB_tank2_TepeLambasiKirmizi = true; } else { PlcTag.DB_tank2_TepeLambasiKirmizi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 4)) { PlcTag.DB_tank2_TepeLambasiSari = true; } else { PlcTag.DB_tank2_TepeLambasiSari = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 5)) { PlcTag.DB_tank2_TepeLambasiYesil = true; } else { PlcTag.DB_tank2_TepeLambasiYesil = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 6)) { PlcTag.DB_tank3_TepeLambasiKirmizi = true; } else { PlcTag.DB_tank3_TepeLambasiKirmizi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte03, 7)) { PlcTag.DB_tank3_TepeLambasiSari = true; } else { PlcTag.DB_tank3_TepeLambasiSari = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte04, 0)) { PlcTag.DB_tank3_TepeLambasiYesil = true; } else { PlcTag.DB_tank3_TepeLambasiYesil = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte04, 1)) { PlcTag.DB_tank4_TepeLambasiKirmizi = true; } else { PlcTag.DB_tank4_TepeLambasiKirmizi = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte04, 2)) { PlcTag.DB_tank4_TepeLambasiSari = true; } else { PlcTag.DB_tank4_TepeLambasiSari = false; }
                    if (IsBitSet(PlcTag.Db_OutputByte04, 3)) { PlcTag.DB_tank4_TepeLambasiYesil = true; } else { PlcTag.DB_tank4_TepeLambasiYesil = false; }

                    return true;
                }
                else
                {
                    Connection = false;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool ReadByte(int db, int adres, int uzunluk)//KONTROL DEISKENLERI OKUNUYOR
        {
            if (Connection == true)
            {
                res = dc.readBytes(libnodave.daveDB, db, adres, uzunluk, memoryBuffer);
                if (res == 0)
                {
                    PlcTag.Db_KontrolByte00 = memoryBuffer[0];
                    PlcTag.Db_KontrolByte01 = memoryBuffer[1];
                    return true;
                }
                else
                {
                    Connection = false;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ReadByte2(int db, int adres, int uzunluk)//KONTROL DEISKENLERI OKUNUYOR
        {
            if (Connection)
            {
                res = dc.readBytes(libnodave.daveDB, db, adres, uzunluk, memoryBuffer);
                if (res == 0)
                {
                    PlcTag.Byte00 = memoryBuffer[0];//kullanılmıyor
                    PlcTag.Byte01 = memoryBuffer[1];//kullanılmıyor
                    PlcTag.Byte02 = memoryBuffer[2];//kullanılmıyor
                    PlcTag.Byte03 = memoryBuffer[3];//kullanılmıyor
                    PlcTag.Byte04 = memoryBuffer[4];
                    PlcTag.Byte05 = memoryBuffer[5];
                    PlcTag.Byte06 = memoryBuffer[6];
                    PlcTag.Byte07 = memoryBuffer[7];
                    PlcTag.Byte08 = memoryBuffer[8];//Yedek
                    PlcTag.Byte09 = memoryBuffer[9];//Yedek

                    PlcTag.Db_tank1_IslemDurumu = PlcTag.Byte04;
                    PlcTag.Db_tank2_IslemDurumu = PlcTag.Byte05;
                    PlcTag.Db_tank3_IslemDurumu = PlcTag.Byte06;
                    PlcTag.Db_tank4_IslemDurumu = PlcTag.Byte07;

                    return true;
                }
                else
                {
                    Connection = false;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool ReadInteger(int db, int adres, int uzunluk)
        {
            if (Connection)
            {
                res = dc.readBytes(libnodave.daveDB, db, adres, uzunluk * 2, null);
                if (res == 0)
                {
                    PlcTag.Db_tank1AlarmWord = dc.getS16();
                    PlcTag.Db_tank2AlarmWord = dc.getS16();
                    PlcTag.Db_tank3AlarmWord = dc.getS16();
                    PlcTag.Db_tank4AlarmWord = dc.getS16();
                    PlcTag.Db_genelAlarmWord = dc.getS16();

                    PlcTag.Db_tank1IslemAdim = dc.getS16();
                    PlcTag.Db_tank1ProsesAdim = dc.getS16();
                    PlcTag.Db_tank1CalismaZamani = dc.getS16();

                    PlcTag.Db_tank2IslemAdim = dc.getS16();
                    PlcTag.Db_tank2ProsesAdim = dc.getS16();
                    PlcTag.Db_tank2CalismaZamani = dc.getS16();

                    PlcTag.Db_tank3IslemAdim = dc.getS16();
                    PlcTag.Db_tank3ProsesAdim = dc.getS16();
                    PlcTag.Db_tank3CalismaZamani = dc.getS16();

                    PlcTag.Db_tank4IslemAdim = dc.getS16();
                    PlcTag.Db_tank4ProsesAdim = dc.getS16();
                    PlcTag.Db_tank4CalismaZamani = dc.getS16();

                    PlcTag.Db_tank1ToplamSure = dc.getS16();
                    PlcTag.Db_tank2ToplamSure = dc.getS16();
                    PlcTag.Db_tank3ToplamSure = dc.getS16();
                    PlcTag.Db_tank4ToplamSure = dc.getS16();

                    return true;
                }
                else
                {
                    Connection = false;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool ReadReal(int db, int adres, int uzunluk)
        {
            if (Connection)
            {
                res = dc.readBytes(libnodave.daveDB, db, adres, uzunluk * 4, null);
                if (res == 0)
                {
                    //PlcTag.Db_kazan1Sicaklik1 =  Convert.ToSingle(string.Format("{0:F4}", dc.getFloat()));

                    PlcTag.Db_kazan1Sicaklik1 = dc.getFloat();
                    PlcTag.Db_kazan1Sicaklik2 = dc.getFloat();
                    PlcTag.Db_kazan1Sicaklik3 = dc.getFloat();


                    PlcTag.Db_kazan2Sicaklik1 = dc.getFloat();
                    PlcTag.Db_kazan2Sicaklik2 = dc.getFloat();
                    PlcTag.Db_kazan2Sicaklik3 = dc.getFloat();


                    PlcTag.Db_kazan3Sicaklik1 = dc.getFloat();
                    PlcTag.Db_kazan3Sicaklik2 = dc.getFloat();
                    PlcTag.Db_kazan3Sicaklik3 = dc.getFloat();


                    PlcTag.Db_kazan4Sicaklik1 = dc.getFloat();
                    PlcTag.Db_kazan4Sicaklik2 = dc.getFloat();
                    PlcTag.Db_kazan4Sicaklik3 = dc.getFloat();


                    PlcTag.Db_kazan12OrtakVakum = dc.getFloat();
                    PlcTag.Db_kazan34OrtakVakum = dc.getFloat();

                    PlcTag.Db_kazan1Vakum = dc.getFloat();
                    PlcTag.Db_kazan2Vakum = dc.getFloat();
                    PlcTag.Db_kazan3Vakum = dc.getFloat();
                    PlcTag.Db_kazan4Vakum = dc.getFloat();

                    PlcTag.Db_kazan1Sicaklik4 = dc.getFloat();
                    PlcTag.Db_kazan1Sicaklik5 = dc.getFloat();

                    PlcTag.Db_kazan2Sicaklik4 = dc.getFloat();
                    PlcTag.Db_kazan2Sicaklik5 = dc.getFloat();

                    PlcTag.Db_kazan3Sicaklik4 = dc.getFloat();
                    PlcTag.Db_kazan3Sicaklik5 = dc.getFloat();

                    PlcTag.Db_kazan4Sicaklik4 = dc.getFloat();
                    PlcTag.Db_kazan4Sicaklik5 = dc.getFloat();

                    return true;
                }
                else
                {
                    Connection = false;
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public static bool WriteSingleRegister(int db, int adres, short deger)
        {
            if (Connection)
            {
                buffer = BitConverter.GetBytes(deger);
                Vout[1] = buffer[0];
                Vout[0] = buffer[1];
                int res = dc.writeBytes(libnodave.daveDB, db, adres, 2, Vout);

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool WriteRealRegister(int db, int adres, float deger)
        {
            if (Connection)
            {
                //uint uideger;
                //uideger = (BitConverter.ToUInt32(BitConverter.GetBytes(deger), 0));
                //buffer = BitConverter.GetBytes(uideger);

                buffer = BitConverter.GetBytes(deger);
                Vout[3] = buffer[0];
                Vout[2] = buffer[1];
                Vout[1] = buffer[2];
                Vout[0] = buffer[3];
                int res = dc.writeBytes(libnodave.daveDB, db, adres, 4, Vout);

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool WriteBool(int db, int AdrByte, int AdrBit, byte deger)
        {
            if (Connection)
            {
                Vout[0] = deger;
                int res = dc.writeBits(libnodave.daveDB, db, (AdrByte * 8) + AdrBit, 1, Vout);

                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ReceteVerileriGonder(RECETELER recete, int tankId)
        {
            try
            {
                TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities();
                List<RECETE_DETAY> listRecete = db.Recete_Detaylar.Where(x => x.RECETE_ID == recete.RECETE_ID).ToList();

                int adimOffset = 0;
                switch (tankId)//Recete Toplam Adim Numarası
                {
                    case 1:
                        adimOffset = 0;
                        WriteSingleRegister(1, 62, Convert.ToInt16(listRecete.Count));
                        break;
                    case 2:
                        adimOffset = 101;
                        WriteSingleRegister(1, 64, Convert.ToInt16(listRecete.Count));
                        break;
                    case 3:
                        adimOffset = 202;
                        WriteSingleRegister(1, 66, Convert.ToInt16(listRecete.Count));
                        break;
                    case 4:
                        adimOffset = 303;
                        WriteSingleRegister(1, 68, Convert.ToInt16(listRecete.Count));
                        break;
                    default:
                        adimOffset = 0;
                        break;
                }

                int bin = 0;

                int sayac = 0;
                for (int adim = adimOffset; adim < listRecete.Count + adimOffset; adim++)
                {
                    bin = ((adim * 18) + 18);

                    WriteSingleRegister(7, bin + 0, Convert.ToInt16(listRecete[sayac].ADIM));
                    WriteSingleRegister(7, bin + 2, Convert.ToInt16(listRecete[sayac].SAAT));
                    WriteRealRegister(7, bin + 4, Convert.ToInt16(listRecete[sayac].DERECE));
                    WriteRealRegister(7, bin + 8, Convert.ToInt16(listRecete[sayac].VAKUM_DEGERI));
                    WriteRealRegister(7, bin + 12, Convert.ToInt16(listRecete[sayac].TAHLIYE_DEGERI));

                    WriteBool(7, bin + 16, 0, Convert.ToByte(listRecete[sayac].ISITMA));
                    WriteBool(7, bin + 16, 1, Convert.ToByte(listRecete[sayac].VAKUM));
                    WriteBool(7, bin + 16, 2, Convert.ToByte(listRecete[sayac].TAHLIYE));

                    sayac++;
                }

                return true;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                MessageBox.Show(string.Format("{0} Reçete Gönderme Hatası:\n\n{1}", tankId, ex));
                Connection = false;
                return false;
            }
        }
        public static bool AlarmKontrolEt(int TankId, int AlarmCurrent, int AlarmOld, ISLEM_BASLIK IslemBaslik)
        {
            ARIZA_TURLERI ariza = new ARIZA_TURLERI();
            List<string> arizalar = new List<string>();

            try
            {
                int[] bitsCurrent = ARIZA_TURLERI.ArizayiListeyeCevir(AlarmCurrent);
                int[] bitsOld = ARIZA_TURLERI.ArizayiListeyeCevir(AlarmOld);

                for (int i = 0; i < bitsOld.Length; i++)
                {
                    if (bitsCurrent[i] > bitsOld[i])
                    {
                        string mesaj = string.Format("{0} Nolu Tankta {1} Arızası", TankId, ariza.ArizaBul(i));
                        arizalar.Add(mesaj);

                        VeritabaninaKaydet(IslemBaslik, mesaj, TankId);
                    }
                }

                MailAtAlarm(arizalar);
                return true;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                return false;
            }
        }
        public static bool AlarmKontrolEtGenel(int AlarmGenelCurrent, int AlarmGenelOld, ISLEM_BASLIK IslemBaslik)
        {
            ARIZA_GENEL arizaGenel = new ARIZA_GENEL();
            List<string> arizalar = new List<string>();

            try
            {
                int[] bitsCurrent = ARIZA_TURLERI.ArizayiListeyeCevir(AlarmGenelCurrent);
                int[] bitsOld = ARIZA_TURLERI.ArizayiListeyeCevir(AlarmGenelOld);

                for (int i = 0; i < bitsOld.Length; i++)
                {
                    if (bitsCurrent[i] > bitsOld[i])
                    {
                        string mesaj = string.Format("{0} Arızası", arizaGenel.ArizaBul(i));
                        arizalar.Add(mesaj);

                        VeritabaninaKaydet(IslemBaslik, mesaj, 0);
                    }
                }

                MailAtAlarm(arizalar);
                return true;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                return false;
            }
        }
        public static void MailAtAlarm(List<string> arizalar)
        {
            try
            {
                if (PlcTag.mailList.Count == 0)
                {
                    //MessageBox.Show("Mail Adresi Yok");
                    return;
                }

                var message = new MailMessage();
                message.To.Add(string.Join(",", PlcTag.mailList));
                message.Subject = "Arıza";
                message.Body = "<h2>Aşağıda Belirtilen Arıza(lar) Oluşmuştur.</h2>";

                foreach (string item in arizalar)
                {
                    message.Body += "\n<h4>" + item + "</h4>\n";
                };

                message.IsBodyHtml = true;
                message.BodyEncoding = Encoding.UTF8;

                MailSend(message);
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }

        public static void MailAt(string MesajBaslik, string MesajDetay)
        {
            try
            {
                if (PlcTag.mailList.Count == 0)
                {
                    //MessageBox.Show("Mail Adresi Yok");
                    return;
                }

                var message = new MailMessage();
                message.To.Add(string.Join(",", PlcTag.mailList));
                message.Subject = "Bilgilendirme";
                message.Body = "<h2>" + MesajBaslik + "</h2>";
                message.Body += "\n<h3>" + MesajDetay + "</h3>\n";
                message.BodyEncoding = Encoding.UTF8;
                message.IsBodyHtml = true;

                MailSend(message);
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }

        private static async void MailSend(MailMessage message)
        {
            try
            {
                message.From = new MailAddress("alikara06@outlook.com"); // gönderecek kişi maili eklenecek.

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "alikara06@outlook.com", //gönderecek kişi maili eklenecek.
                        Password = ""  //gönderecek kişi mail şifresi eklenecek.
                    };

                   
                    smtp.Credentials = credential;
                    smtp.Host = "smtp-mail.outlook.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }


        private static void VeritabaninaKaydet(ISLEM_BASLIK IslemBaslik, string ArizaAciklama, int tankId)
        {
            try
            {
                if (!PlcTag.IsDemoMod)
                {
                    TrafoTest_AppDBEntities db = new TrafoTest_AppDBEntities();
                    db.Alarmlar.Add(new ALARM
                    {
                        TANK_ID = tankId,
                        ISLEM_BASLIK_ID = IslemBaslik.ISLEM_BASLIK_ID,
                        OLUSMA_TARIHI = DateTime.Now,
                        ACIKLAMA = ArizaAciklama
                    });

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
            }
        }
    }
}