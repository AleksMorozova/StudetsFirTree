using GameProcess.BL;
using GameProcess.BL.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    [Serializable]
    public class Presenter
    {
        private IFighting _process;
        [NonSerialized]
        private readonly IGameForm _view;
        private readonly IManager _manager;

        public Presenter(IGameForm _view, IFighting _process, IManager _manager)
        {
            this._process = _process;
            this._view = _view;
            this._manager = _manager;
            _view.SetBindingSource(_process);
            _view.Binding();
            _process.Player1.Name = _view.NamePlayer1;

            SuscribeForm();
            SuscribePlayer(_process.Player1);
            SuscribePlayer(_process.Player2);
        }

        #region Forms' events
        private void _view_BodyPartClick(object sender, EventArgsBodyParts e)
        {
            _process.MakeStep(e.Part);
        }
        private void _manager_SaveGame(object sender, EventArgs e)
        {
            _manager.SaveGame(_process);
        }
        private void _manager_LoadGame(object sender, EventArgs e)
        {
            IFighting _loadedGame = _manager.LoadGame();
            if (_loadedGame != null)
            {
                _process = _loadedGame;
                _view.NamePlayer1 = _process.Player1.Name;
                _view.SetBindingSource(_process);
                _view.UnblockGame();
                _view.ClearLog();
                foreach (string item in _process.Log)
                {
                    _view.Log = item;
                }
                SuscribePlayer(_process.Player1);
                SuscribePlayer(_process.Player2);
                _process.NotifyPropertyChanged("");
            }
        }
        #endregion

        #region Logics' events
        private void _view_EndGame(object sender, EventArgsFighter e)
        {
            UnsuscribePlayer(_process.Player1);
            UnsuscribePlayer(_process.Player2);

            _view.Log = e.Name + " is dead!";
            _view.Log = "Fight over in " + _process.Round + " rounds";
            _view.Log = "*Log saved*. Log saved to the root directory.";
            string winner = (sender == _process.Player1) ? _process.Player2.Name : _process.Player1.Name;
            MessageBox.Show(e.Name + " is dead!", winner + " win!", MessageBoxButtons.OK);
            _manager.SaveLog(_process.Log);
            _view.BlockGame(winner);
        }

        private void _view_AddLogInfoWound(object sender, EventArgsFighter e)
        {
            _view.Log = e.Name + " taked damage! Now he has " + e.HP;
            _process.AddToLog(e.Name + " taked damage! Now he has " + e.HP);
        }

        private void _view_AddLogInfoBlock(object sender, EventArgsFighter e)
        {
            _view.Log = e.Name + " blocked attack!";
            _process.AddToLog(e.Name + " blocked attack!");
        }
        #endregion

        private void SuscribeForm()
        {
            _view.ButHeadClick += _view_BodyPartClick;
            _view.ButBodyClick += _view_BodyPartClick;
            _view.ButLegClick += _view_BodyPartClick;
            _view.ButLoadGameClick += _manager_LoadGame;
            _view.ButSaveGameClick += _manager_SaveGame;
        }
        private void SuscribePlayer(IFighter _player)
        {
            _player.Block += _view_AddLogInfoBlock;
            _player.Wound += _view_AddLogInfoWound;
            _player.Death += _view_EndGame;
        }
        private void UnsuscribePlayer(IFighter _player)
        {
            _player.Block -= _view_AddLogInfoBlock;
            _player.Wound -= _view_AddLogInfoWound;
            _player.Death -= _view_EndGame;
        }
    }
}
