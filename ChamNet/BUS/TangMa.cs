using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamNet.BUS
{
    public class TangMa
    {
        public string MaTiepTheo(string macuoi, string dauma)
        {
            int matiep = int.Parse(macuoi.Remove(0, dauma.Length)) + 1;
            int lengthNumberID = macuoi.Length - dauma.Length;
            string so0 = "";
            for (int i = 1; i <= lengthNumberID; i++)
            {
                if (matiep < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumberID - i; j++)
                    {
                        so0 += "0";
                    }
                    return dauma + so0 + matiep.ToString();
                }
            }
            return dauma + matiep;
        }
    }
}
