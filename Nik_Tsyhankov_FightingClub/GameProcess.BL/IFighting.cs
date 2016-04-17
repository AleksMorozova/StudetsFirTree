using GameProcess.BL.Fighters;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GameProcess.BL
{
    public interface IFighting : INotifyPropertyChanged
    {
        IFighter Player1
        {
            get;
        }
        IFighter Player2
        {
            get;
        }
        int Round
        {
            get;
        }
        string Status
        {
            get;
        }
        List<string> Log
        {
            get;
        }
        void MakeStep(BodyParts _part);
        void AddToLog(string item);
        void NotifyPropertyChanged(String propertyName);
    }
}
