﻿using GameProcess.BL;
using System;
using System.Windows.Forms;

namespace FightingClub_Nikita
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            Logic game = new Logic();
            FileManager manager = new FileManager();

            Presenter presenter = new Presenter(form, game, manager);

            Application.Run(form);
        }
    }
}
