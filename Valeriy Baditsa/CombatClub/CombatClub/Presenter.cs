using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace CombatClub
{   
    [Serializable]
    class Presenter
    {        
        [NonSerialized]
        private IMainForm view;
        private IPlayer player;
        private IPlayer computerPlayer;

        public Presenter() { }  

        public Presenter(IMainForm form)
        {
            this.view = form;                        
            this.computerPlayer = new ComputerPlayer();
            this.player = new Player();
            this.view.SetBinding(this.player, this.computerPlayer);
            SubscribeViewEvents();
            SubscribeModelEvents();         
        }            

        void SubscribeViewEvents()
        {
            view.HeadClick += view_HeadClick;
            view.BodyClick += view_BodyClick;
            view.LegsClick += view_LegsClick;
            view.newGameToolStripMenuItemClick += view_newGameToolStripMenuItemClick;
            view.loadGameToolStripMenuItemClick += view_loadGameToolStripMenuItemClick;
            view.saveGameToolStripMenuItemClick += view_saveGameToolStripMenuItemClick;
        }
        void SubscribeModelEvents()
        {
            this.player.Wound += player_Wound;
            this.player.Death += player_Death;
            this.player.Block += player_Block;
            this.computerPlayer.Wound += player_Wound;
            this.computerPlayer.Death += player_Death;
            this.computerPlayer.Block += player_Block;
        }
        void UnsubscribeModelEvents()
        {
            this.player.Wound -= player_Wound;
            this.player.Death -= player_Death;
            this.player.Block -= player_Block;
            this.computerPlayer.Wound -= player_Wound;
            this.computerPlayer.Death -= player_Death;
            this.computerPlayer.Block -= player_Block;
        }
        void UnsubscribeViewEvents()
        {
            view.HeadClick -= view_HeadClick;
            view.BodyClick -= view_BodyClick;
            view.LegsClick -= view_LegsClick;
            view.newGameToolStripMenuItemClick -= view_newGameToolStripMenuItemClick;
        }       

        void view_saveGameToolStripMenuItemClick(object sender, EventArgs e)
        {
            SerializationManager.SaveProcGame(this);            
        }        

        void view_loadGameToolStripMenuItemClick(object sender, EventArgs e)
        {
            Presenter presenter = new Presenter();
            presenter = SerializationManager.LoadGameProc();

            if (presenter != null)
            {

                this.player.Init(presenter.player);
                this.computerPlayer.Init(presenter.computerPlayer);
                this.view.ProgressBar_CompName.Maximum = presenter.computerPlayer.HP;
                this.view.ProgressBar_Player.Maximum = presenter.player.HP;

                if (player.Attacker)
                    view.buttonText("Attack ");
                else
                    view.buttonText("Block ");
                view.buttonVisible = true;
            }
            else
                MessageBox.Show("You don't change file");
        }       

        void view_newGameToolStripMenuItemClick(object sender, EventArgs e)
        {            
            CreatePlayers(new Player("VALERIY", 32), new ComputerPlayer("COMP", 44));           
        }

        public void CreatePlayers(IPlayer player, IPlayer compPlayer)
        {
            this.view.ProgressBar_CompName.Maximum = compPlayer.HP;
            this.view.ProgressBar_Player.Maximum = player.HP;
            this.player.Init(player);
            this.computerPlayer.Init(compPlayer);    
         
            this.player.Attacker = true;
            this.computerPlayer.Attacker = false;                          

            view.buttonText("Attack ");                        
            view.buttonVisible = true;       
        }
   
        void player_Block(object sender, PlayerEventArgs e)
        {
            view.LstBox = e.name+": удар блокирован";
        }

        public void GameOver()
        {
            view.buttonVisible = false;
        }

        void player_Death(object sender, PlayerEventArgs e)
        {
            view.LstBox = e.name + ": убит :(";
            GameOver();            
        }      

        void player_Wound(object sender, PlayerEventArgs e)
        {
            string typePlayer = sender.GetType().ToString();

            if (typePlayer.Equals("CombatClub.Player"))
            {
                // view.lblSetHpPlayer(e.Hp);
            }
            
            else
                if (typePlayer.Equals("CombatClub.ComputerPlayer"))
                {
                    //view.lblSetHpComp(e.Hp);
                }

            view.LstBox = e.name + ": нанесен урон";
        }

        void view_HeadClick(object sender, EventArgs e)
        {
            ChangePartBody(BodyParts.head);
        }

        void view_BodyClick(object sender, EventArgs e)
        {            
            ChangePartBody(BodyParts.body);
        }

        void view_LegsClick(object sender, EventArgs e)
        {
            ChangePartBody(BodyParts.legs);
        }

        void ChangePartBody(BodyParts bodyPart)
        {            
            if (player.Attacker)
            {
                computerPlayer.SetBlock(bodyPart);
                computerPlayer.GetHit(bodyPart);         
                if (player != null && computerPlayer != null)
                {
                    player.Attacker = false;
                    computerPlayer.Attacker = true;
                    view.buttonText("Block");                    
                }
            }
            else
            {
                if (computerPlayer.Attacker)
                {
                    player.SetBlock(bodyPart);
                    player.GetHit(computerPlayer.ReturnAttackPartBody());
                    if (player != null && computerPlayer != null)
                    {
                        player.Attacker = true;
                        computerPlayer.Attacker = false;
                        view.buttonText("Attack");                        
                    }
                }
            }
        }

        

    }
}

