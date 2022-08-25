using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafoTest_Model.Arizalar
{

    public class ARIZA_GENEL
    {
        List<KeyValuePair<string, int>> ArızaGenelList { get; set; }
        public ARIZA_GENEL()
        {
            ArızaGenelList = new List<KeyValuePair<string, int>>();

            ArızaGenelList.Add(new KeyValuePair<string, int>("Sogutucu Tank 1 Arıza", 0));
            ArızaGenelList.Add(new KeyValuePair<string, int>("Sogutucu Tank 2 Arıza", 1));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 2));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 3));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 4));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 5));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 6));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 7));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 8));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 9));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 10));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 11));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 12));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 13));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 14));
            ArızaGenelList.Add(new KeyValuePair<string, int>("-", 15));
        }

        public string ArizaBul(int index)
        {
            return ArızaGenelList.FirstOrDefault(x => x.Value == index).Key;
        }
    }
}