﻿using GameProcess.BL.Fighters;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    public interface IGameForm
    {
        string NamePlayer1
        {
            get;
            set;
        }
        string NameCPUPlayer
        {
            set;
        }
        int Title
        {
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
        void HPPlayers(int player1, int player2);
        void BlockGame(string _winner);
        void UnblockGame();
        void ClearLog();
        void Binding(BindingSource binding);
        event EventHandler<EventArgsBodyParts> ButHeadClick;
        event EventHandler<EventArgsBodyParts> ButBodyClick;
        event EventHandler<EventArgsBodyParts> ButLegClick;
        event EventHandler ButLoadGameClick;
        event EventHandler ButSaveGameClick;

    }
}
