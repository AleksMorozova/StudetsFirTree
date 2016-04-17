using GameProcess.BL;
using GameProcess.BL.Fighters;
using System;

namespace FightingClub_Nikita
{
    public interface IGameForm
    {
        string NamePlayer1
        {
            get;
            set;
        }
        int Rounds
        {
            set;
        }
        string Log
        {
            set;
        }
        void BlockGame(string _winner);
        void UnblockGame();
        void ClearLog();
        void Binding();
        void SetBindingSource(IFighting process);
        event EventHandler<EventArgsBodyParts> ButHeadClick;
        event EventHandler<EventArgsBodyParts> ButBodyClick;
        event EventHandler<EventArgsBodyParts> ButLegClick;
        event EventHandler ButLoadGameClick;
        event EventHandler ButSaveGameClick;

    }
}
