using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamagochiGame
{
 
    public class logical_Eating
    {
        tamagochi_deth deth = new tamagochi_deth();
        
        public   void animals_hangre(PictureBox AnimalsPB,Label hangry_lable, int count_food , string reding_str, int hangry_label_str)
        {

            
           
            if (count_food>150)
                {
                    AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Голодный.png");
                }
              
            

        }

        public void animals_sleep (Label fatigue_label, int count_sleep, PictureBox AnimalsPB, int sleep, string reding_str,int sleep_int)//Простая логика работы прогресбаров (Надо подумать на что их заменить   ,либоже лейб , либоже что то другое пока тестова так ) 
        {

            // придумать реализацию смени изоброажения , так как получаеться что изображения будут накладоваться друг на друга 
            //придумать условие что  бы логика игры друг с другом не конфликтовала 
            // не забыть про логику смерти , реализовать данную логику 
            // подумать как сделать так что  бы при выходи из игры изменение состаяние тамоги прогресировало либо же регрисировало(может быть использовать внутренеe .ADO?)
            //Незабыть про ДОКУМЕНТАЦИЮ К ПРИЛОЖЕНИЮ !!!!!!!!!!!!!!!!!!!!

            
           
            if (count_sleep > 200)
            {
                AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Усталый.png");

            }
         
        }

        public void animals_sad(Label sad_labele, int count_sad, PictureBox AnimalsPB, string reding_str, int sad_int)
        {
         
           
            if (count_sad > 250)
                AnimalsPB.Image = new Bitmap($"{Application.StartupPath}\\Скучно.png");
         
        }
      
    }
}
