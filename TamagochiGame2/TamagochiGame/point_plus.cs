using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagochiGame
{
    class point_plus : tamagochi_deth
    {
        int  mm;/// <summary>
        /// дата из файла после послденего закрытия его
        /// </summary>
        int dd;
        int mm_2;/// <summary>
        /// дата из файла после открытие 
        /// </summary>
        int dd_2;
        int score_dd;
        int score_mm;
        int counter_dd;
        int counter_mm;
        int hh;
        int hh_2;
        int min;
        int min_2;
        int score_hh;
        int counter_hh;
        int score_min;
        int counter_min;
        tamagochi_deth deth = new tamagochi_deth();
       /* public void score_pluse(ref int counter_dd,ref int counter_mm, ref int counter_hh,ref int counter_min)
        {
         deth.read_file_for_last_close_data(ref mm, ref dd);
            deth.read_file_for_new_open_file(ref dd_2, ref mm_2);
            deth.read_file_for_last_house_and_minuts(ref hh, ref min);
            deth.read_file_for_last_house_and_minuts(ref hh_2, ref min_2);
            score_dd = dd - dd_2;
            score_mm = mm - mm_2;
            score_min = min - min_2;
            score_hh = hh - hh_2;
            counter_dd = (score_dd * 24) * 60;
            counter_mm = (score_mm * 720) * 60;
            counter_min = score_min;
            counter_hh = score_hh * 60;
        }
        public void label_score(ref int  Tik_Label)
        {
            int Tik;
            int Tik_2;
            int Tik_3;
            int Tik_4;
            score_pluse(ref counter_dd, ref counter_mm,ref counter_hh,ref counter_min);
           Tik = counter_dd * 1;
           Tik_2 = counter_mm * 1;
           Tik_3 = counter_hh * 1;
           Tik_4 = counter_min * 1;
           Tik_Label = Tik + Tik_2+Tik_3+Tik_4;
        }
      

          */
    }
}
