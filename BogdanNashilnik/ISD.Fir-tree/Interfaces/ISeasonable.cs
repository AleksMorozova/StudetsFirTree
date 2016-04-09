namespace ISD.Fir_tree.Interfaces
{
    interface ISeasonable
    {
        Season Season { get; }
        void ChangeSeason(Season season);
    }
}
