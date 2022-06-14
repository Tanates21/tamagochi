using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamagochiGame
{
    public partial class Tamagochi : Form
    {

        logical_Eating logical = new logical_Eating();
       
        int count_food = 0;/// <summary>
        int count_sleep = 0;/// <summary>
        int count_sad = 0;
        int hangry_label_str;/// <summary>
        int sad_int;                    /// общий счетчик который ведет счет для записи характерстик в лайбел 
        int sleep_int;               /// </summary>
        int sleep = 1;/// <summary///  переменная которая нужна для метода animals_sleep , что  бы изменять коректно  допадобную графику, возврашает 1 если тамагочи спит ю                      
        /// </summary>
        string reding_str;//строка принимает статистику из файла
        string reding_newgame;//строка которая принимает нулевую статистику для новой игры
        string label_h;
        string sleeping;
        string play;
        int hangry = 1;
        int sad = 1;
        tamagochi_deth deth = new tamagochi_deth();
        DialogResult result;
        point_plus point = new point_plus();
        int Tik_label;
        
   
     
        public Tamagochi()
        {
           
            InitializeComponent();
           
            
            deth.save_before_date(hangry_lable, sad_labele, fatigue_label);
            deth.hangry_l(hangry_lable, reding_str, ref hangry_label_str);
            deth.plaing(sad_labele, reding_str, ref sad_int);
            deth.sleep_met(fatigue_label, reding_str, ref sleep_int);
           /* point.label_score(ref Tik_label);*/
            
            count_food = hangry_label_str;
            count_sad = sad_int;
            count_sleep = sleep_int;
            Form2 form = new Form2();
            form.Show();
            this.Form = form;
            AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Обычный.png");

        }
          Form2 Form;
        Deth deth_logical = new Deth();
        private void timer1_Tick(object sender, EventArgs e)
        {
            

            Form.Location = new Point(this.Location.X + 8, this.Location.Y + 30);
           // Таймер для заднего фона что бы моментально он отображался 
        }

        private void Tamagochi_Load(object sender, EventArgs e)
        {
            count_food += Tik_label;
            count_sad += Tik_label;
            count_sleep += Tik_label;


        }
       
        private void btn_playforAN_Click(object sender, EventArgs e)
        {
            deth.plaing(sad_labele, reding_str, ref sad_int);
            if (sad_int!=0)
            {
                  AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Счастье.png");
                  sad_labele.Text = Convert.ToString($"{count_sad -= 2}"+"/300");
   
            }
            else if (sad_int>=0)
            {
                btn_playforAN.Enabled = false;
                AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Обычный.png");
            }
        }
        
        private void btn_sleep_Click(object sender, EventArgs e)
        {

                sleep = 0;
                
               AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Спит.png");
            

        }

        private  void progresbar_timer_Tick(object sender, EventArgs e)
        {
            
            count_food++;
            btn_givefood.Enabled = true;
            hangry = 0;
            if (count_food != 300)
            {
                hangry_lable.Text = Convert.ToString($"{count_food}" + "/300");

                logical.animals_hangre(AnimalsPB, hangry_lable, count_food,reding_str,hangry_label_str);

            }

            else
            {
                timer_sed.Stop();
                timer_fatigue.Stop();
                progresbar_timer.Stop();
                Deth_pat();
            }
        }

        private  void timer_sed_Tick(object sender, EventArgs e)
        {
            count_sad++;
            btn_playforAN.Enabled = true;
            sad = 0;
            if (count_sad != 300)
            {

                sad_labele.Text = Convert.ToString($"{count_sad}" + "/300");
                logical.animals_sad(sad_labele, count_sad, AnimalsPB,reding_str,sad_int);
            }
            else
            {
                timer_fatigue.Stop();
                progresbar_timer.Stop();
                timer_sed.Stop();
                Deth_pat();
            }
        }

        private  void timer_fatigue_Tick(object sender, EventArgs e)
        {

            deth.sleep_met(fatigue_label, reding_str, ref sleep_int);
            count_sleep++;
            if (count_sleep!=0)
            { 
                
                if (sleep == 0)
                {

                    AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Спит.png");
                    fatigue_label.Text = Convert.ToString($"{count_sleep-=2}" + "/350");
                }

                
            }

            else
                btn_wakeupp_Click(sender, e);


            if (count_sleep != 350)
            {
                fatigue_label.Text = Convert.ToString($"{count_sleep}" + "/350");
                logical.animals_sleep(fatigue_label, count_sleep, AnimalsPB, sleep,reding_str,sleep_int);
            }

            else
            {
                progresbar_timer.Stop();
                timer_sed.Stop();
                timer_fatigue.Stop();
                Deth_pat();
            }
           
        }

        

        private void btn_wakeupp_Click(object sender, EventArgs e)
        {
            sleep = 1;
            AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Обычный.png");



        }

      

        private void btn_givefood_Click(object sender, EventArgs e)
        {

            deth.hangry_l(hangry_lable, reding_str, ref hangry_label_str);
            if (hangry_label_str!=0)
            {
                


               AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Ест.png");
                hangry_lable.Text = Convert.ToString($"{count_food -= 2}" + "/300");
              


            }
            else if (hangry_label_str>=0)
            {
                btn_givefood.Enabled = false;
                AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Обычный.png");
            }
        }

        private void Tamagochi_FormClosed(object sender, FormClosedEventArgs e)
        {
           
                deth.save_data_for_file(hangry_lable, sad_labele, fatigue_label);

        }
     
        void Deth_pat()
        {


            if (count_food == 300 || count_sleep == 350 || count_sad == 300)
            {
                AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Смерть.png");
                result = MessageBox.Show("Вы хотите начать с начала?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    deth.reding_mid_file_for_newgame(hangry_lable, sad_labele, fatigue_label, reding_newgame);
                    timer_sed.Start();
                    timer_fatigue.Start();
                    progresbar_timer.Start();
                    count_food = 0;
                    count_sad = 0;
                    count_sleep = 0;
                }
            }

        }
       
    }
}
