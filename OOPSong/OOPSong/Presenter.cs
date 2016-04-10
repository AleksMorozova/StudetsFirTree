using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSong
{
    class Presenter
    {
        IMainForm form;
        Fir fir = new Fir();

        public Presenter(IMainForm form)
        {
            this.form = form;
            this.form.buttonPlaySongClick += form_buttonPlaySongClick;
            this.fir.Born += fir_Born;
            this.fir.Grow += fir_Grow;
            this.fir.ReactionOnSeazon += fir_ReactionOnSeazon;
        }

        void fir_ReactionOnSeazon(object sender, EventArgs e)
        {
            form.ListBoxAddItem("Color = "+ fir.Color.ToString());           
        }

        void fir_Grow(object sender, EventArgs e)
        {
            form.ListBoxAddItem("Fir grow");            
        }

        void fir_Born(object sender, EventArgs e)
        {
            form.ListBoxAddItem("Fir borned");
        }

        public void PlaySong()
        {            
            Place forest = new Forest();
            forest.AddNature(fir);
            fir.OnBorn();
            fir.ProcessGrow();
            //forest.CheckStateAllNature();
            forest.AddSezon(Sezon.winter);
        }

        void form_buttonPlaySongClick(object sender, EventArgs e)
        {
            PlaySong();
        }
    }
}
