using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz_Game
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class GamePlay : ContentPage
    {
        private int counter = 10,correct=0;
        public GamePlay()
        {
            InitializeComponent();
           
        BackgroundImage = "elderWand.jpg";
            question(10);
        }
       

        async void question(int szamlalo)
        {
            helyes.Text = correct.ToString() + " helyes";
                if (szamlalo == 10)
                {
                    this.kerdes.Text = "Ki lehetett volna Harry-n kívül a kiválasztott?";
                    this.Answer_a.Text = "Neville";
                    this.Answer_b.Text = "Luna";
                    this.Answer_c.Text = "Draco";
                    this.Answer_d.Text = "Ron";
                }
                if (szamlalo == 9)
                {
                    this.kerdes.Text = "Ki a bájitaltan tanár a 6. részben?";
                    this.Answer_a.Text = "McGalagony";
                    this.Answer_b.Text = "Piton";
                this.Answer_c.Text = "Lumpsluck";
                this.Answer_d.Text = "Madam Hooch";
                }
            
           if (szamlalo == 8)
            {
                this.kerdes.Text = "Kinek a külsejét veszi fel ifj. Barty Kupor?";
                this.Answer_a.Text = "Hagrid";
                this.Answer_b.Text = "Féregfark";
                this.Answer_c.Text = "Draco";
                this.Answer_d.Text = "Mordon";
            }
            if (szamlalo == 7)
            {
                this.kerdes.Text = "Hány Weasley gyerek van?";
                this.Answer_a.Text = "6";
                this.Answer_b.Text = "7";
                this.Answer_c.Text = "5";
                this.Answer_d.Text = "8";
            }
            if (szamlalo == 6)
            {
                this.kerdes.Text = "Melyik évben jelent meg az első könyv?";
                this.Answer_a.Text = "2000";
                this.Answer_b.Text = "1992";
                this.Answer_c.Text = "2001";
                this.Answer_d.Text = "1997";
            }
            if (szamlalo == 5)
            {
                this.kerdes.Text = "Kinek sérül meg a füle az 5. részben?";
                this.Answer_a.Text = "George";
                this.Answer_b.Text = "Fred";
                this.Answer_c.Text = "Bill";
                this.Answer_d.Text = "Neville";
            }
            if (szamlalo == 4)
            {
                this.kerdes.Text = "Ki nem tagja az ezüst trionak?";
                this.Answer_a.Text = "Neville";
                this.Answer_b.Text = "Seamus";
                this.Answer_c.Text = "Luna";
                this.Answer_d.Text = "Ginny";
            }
            if (szamlalo == 3)
            {
                this.kerdes.Text = "Melyik nem főbenjáró átok?";
                this.Answer_a.Text = "Sectum Sempra";
                this.Answer_b.Text = "Cruciatus";
                this.Answer_c.Text = "Avada Kedavra";
                this.Answer_d.Text = "Imperius";
            }
            if (szamlalo == 2)
            {
                this.kerdes.Text = "Milyen színü Harry szeme?";
                this.Answer_a.Text = "Kék";
                this.Answer_b.Text = "Zöld";
                this.Answer_c.Text = "Barna";
                this.Answer_d.Text = "Szürke";
            }
            if (szamlalo == 1)
            {
                this.kerdes.Text = "Melyik nem tartozik a halál erekjéi közé?";
                this.Answer_a.Text = "Feltámadás köve";
                this.Answer_b.Text = "Láthatatlanná tévö köpeny";
                this.Answer_c.Text = "Griffendél kardja";
                this.Answer_d.Text = "Bodza Pálca";
            }
            if(szamlalo==0)
            {
                await Task.WhenAll(kerdes.FadeTo(0, 1000),
                    Answer_a.FadeTo(0, 1000), Answer_b.FadeTo(0, 1000), Answer_c.FadeTo(0, 1000), Answer_d.FadeTo(0, 1000), helyes.FadeTo(0, 1000), a.FadeTo(0, 1000), b.FadeTo(0, 1000), c.FadeTo(0, 1000), d.FadeTo(0, 1000)
                    ); ; ;
                await Navigation.PushModalAsync(new closePage(correct));
            }
            

        }
        private  void Answer_a_Tapped(object sender, EventArgs e)
        {
            if(counter==10 || counter==5 || counter==3)
            { correct++; }
            counter--;

            question(counter);
            
            

        }
        private  void Answer_b_Tapped(object sender, EventArgs e)
        {
            if(counter==7 || counter==2 || counter==4)
            {
                correct++;
            }
            counter--;
            question(counter);


        }
        private  void Answer_c_Tapped(object sender, EventArgs e)
        {
            if(counter==9 || counter==1)
            {
                correct++;
            }
            counter--;
            question(counter);
        }
        private  void Answer_d_Tapped(object sender, EventArgs e)
        {
            if(counter==8 || counter == 6)
            {
                correct++; 
            }
            counter--;
            question(counter);
        }
    }
}