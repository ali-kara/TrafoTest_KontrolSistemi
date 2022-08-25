using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TrafoTest_Model.Arizalar
{

    public class ARIZA_TURLERI
    {
        List<KeyValuePair<string, int>> ArızaList { get; set; }
        public ARIZA_TURLERI()
        {
            ArızaList = new List<KeyValuePair<string, int>>();

            ArızaList.Add(new KeyValuePair<string, int>("Tahliye Valfi Konum Hatası", 0));
            ArızaList.Add(new KeyValuePair<string, int>("Vakum Valfi Konum Hatası", 1));
            ArızaList.Add(new KeyValuePair<string, int>("Kontaktor Güç Arızası", 2));
            ArızaList.Add(new KeyValuePair<string, int>("Pompa Arıza", 3));
            ArızaList.Add(new KeyValuePair<string, int>("Acil Stop Butonu Basılı", 4));
            ArızaList.Add(new KeyValuePair<string, int>("Sıcaklık Değeri Normalin Üstünde", 5));
            ArızaList.Add(new KeyValuePair<string, int>("Soğutucu Arıza", 6));
            ArızaList.Add(new KeyValuePair<string, int>("Yüksek Isı Sebebi ile Pompa Durduruldu", 7));
            ArızaList.Add(new KeyValuePair<string, int>("-", 8));
            ArızaList.Add(new KeyValuePair<string, int>("-", 9));
            ArızaList.Add(new KeyValuePair<string, int>("-", 10));
            ArızaList.Add(new KeyValuePair<string, int>("-", 11));
            ArızaList.Add(new KeyValuePair<string, int>("-", 12));
            ArızaList.Add(new KeyValuePair<string, int>("-", 14));
            ArızaList.Add(new KeyValuePair<string, int>("-", 15));
        }

        public string ArizaBul(int index)
        {
            return ArızaList.FirstOrDefault(x => x.Value == index).Key;
        }

        public static int[] ArizayiListeyeCevir(int AlarmWord)
        {
            try
            {
                return Convert.ToString(AlarmWord, 2)
                                .PadLeft(16, '0')
                                .Select(c => int.Parse(c.ToString()))
                                .Reverse()
                                .ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return new int[16];
            }
        }
    }
}