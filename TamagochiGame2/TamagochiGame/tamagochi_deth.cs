using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamagochiGame
{
    class tamagochi_deth
    {
        DirectoryInfo di = new DirectoryInfo("DataTime");
        string path = @"DataTime\\BeforyData.txt";
        string path2 = @"DataTime\\NoweData.txt";
        string state;
        string state_now;
     

        public void save_data_for_file(Label hangry_lable, Label sad_labele, Label fatigue_label)//При закрытие фала записывает в файл статистику которая была на момент закрытия 
        {
            StreamWriter sw = new StreamWriter(path);
            state="";
            state =" " +" , "+ hangry_lable.Text+" , "+ sad_labele.Text+" , "+fatigue_label.Text;
            
            try
            {
                if (!di.Exists)//проверка есть ли паппка
                {

                    di.Create();
                }

                else
                {
                    
                    if (File.Exists(path))//проверка есть ли файл
                    {

                        //записывает строку 
                       
                        sw.WriteLine(DateTime.UtcNow.ToString()+state) ;
                        sw.Close();
                        



                    }

                    else
                    {
                        File.Create(path);
                    }
                }

            }
            catch (Exception ex )
            {
                MessageBox.Show($"{ex}");
                
            }

        }
         
        public void hangry_l(Label hangry_label,string reding_str, ref int  hangry_label_str)
        {
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                reding_str = sr.ReadLine();
                string pars_for_zero;
                string[] str_pars = reding_str.Split(',');
                hangry_label.Text = str_pars[2];
                pars_for_zero = str_pars[2];
                string[] str_pars2 = pars_for_zero.Split('/');
                hangry_label_str = Convert.ToInt32(str_pars2[0]);
                
                
            }
            sr.Close();
        }
       public void plaing(Label sad_labele, string reding_str,ref int sad_int)
        {
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                reding_str = sr.ReadLine();
                string[] str_pars = reding_str.Split(',');
                sad_labele.Text = str_pars[1];
                string pars_for_zero;
                pars_for_zero = str_pars[1];
                string[] str_pars2 = pars_for_zero.Split('/');
     
                sad_int = Convert.ToInt32(str_pars2[0]);

            }
            sr.Close();
        }

     public   void sleep_met(Label fatigue_label, string reding_str,ref int sleep_int)
        {
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                reding_str = sr.ReadLine();
                string[] str_pars = reding_str.Split(',');
                fatigue_label.Text = str_pars[3];
                string pars_for_zero;
                pars_for_zero = str_pars[3];
                string[] str_pars2 = pars_for_zero.Split('/');
                sleep_int = Convert.ToInt32(str_pars2[0]);
            }
            sr.Close();

        }
        public void reding_mod_file( string  reding_str, string label_h,string sleeping,string play)//метод для  загрузки  сейва с полными данными
        {

            
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                reding_str= sr.ReadLine();
                string[] str_pars = reding_str.Split(',');
                label_h = str_pars[1];
                sleeping = str_pars[3];
                play = str_pars[2];

            }
            sr.Close();
        }
        public void reding_mid_file_for_newgame(Label hangry_lable, Label sad_labele, Label fatigue_label,  string reding_newgame)
        {
            StreamReader sr = new StreamReader(path2);
            while(!sr.EndOfStream)
            {
                reding_newgame = sr.ReadLine();
                string[] str_pars = reding_newgame.Split(',');
                hangry_lable.Text = str_pars[1];
                sad_labele.Text = str_pars[2];
                fatigue_label.Text = str_pars[3];
            }
            sr.Close();
        }//метод для загрузки новой игры
        public void save_before_date(Label hangry_lable, Label sad_labele, Label fatigue_label)//новый файл для новой даты для проверки показателей, так же буду использовать для открытие сейва
        {
            StreamWriter sw2 = new StreamWriter(path2);
            state_now = "";
            state_now = " " + " , " + hangry_lable.Text + " , " + sad_labele.Text + " , " + fatigue_label.Text;
            try
            {
                
                if (!di.Exists)
                {
                   
                }
                else
                {
                    if (File.Exists(path2))
                    {
                        sw2.WriteLine(DateTime.UtcNow.ToString() + state_now);
                        sw2.Close();

                    }
                    else
                    {
                        File.Create(path2);

                    }
                }
                }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex}");
            }
        }
        public void read_file_for_last_close_data(ref int   mm, ref int dd)//data 
        {
            StreamReader sr = new StreamReader(path);
            while(!sr.EndOfStream)
            {
                state = sr.ReadLine();
                string[] str_parse = state.Split('.');
                mm = Convert.ToInt32(str_parse[1]);
                dd = Convert.ToInt32(str_parse[0]);
            }
            sr.Close();
        }
        public void  read_file_for_new_open_file(ref int dd_2 , ref int mm_2)
        {
            StreamReader sr = new StreamReader(path2);
            while (!sr.EndOfStream)
            {
                state_now = sr.ReadLine();
                string[] str_parse = state_now.Split('.');
                mm_2 = Convert.ToInt32( str_parse[1]);
                dd_2 =Convert.ToInt32(str_parse[0]);
            }
            sr.Close();
            
        }
        public void read_file_for_last_house_and_minuts_2(ref int hh_2, ref int min_2)
        {
            StreamReader sr = new StreamReader(path2);
            while (!sr.EndOfStream)
            {
                string time;
                state_now = sr.ReadLine();
                string[] str_parse = state_now.Split(' ');
                time= Convert.ToString(str_parse[1]);
                string[] pars_time = time.Split(':');
                hh_2 =Convert.ToInt32( pars_time[0]);
                min_2 = Convert.ToInt32(pars_time[1]);
            }
            sr.Close();
        }
        public void read_file_for_last_house_and_minuts(ref int hh,ref int min)
        {
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string time;
                state_now = sr.ReadLine();
                string[] str_parse = state_now.Split(' ');
                time = Convert.ToString(str_parse[1]);
                string[] pars_time = time.Split(':');
                hh = Convert.ToInt32(pars_time[0]);
                min = Convert.ToInt32(pars_time[1]);
            }
            sr.Close();
        }
    }

    
   
}
