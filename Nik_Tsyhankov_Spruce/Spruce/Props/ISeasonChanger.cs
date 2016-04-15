namespace Spruce.Props
{
    public interface ISeasonChanger
    {
        Seasons CurrentSeason { get; }
        int CurrentMonth { get; }
        void ChangeMonth();
        event SeasonHandler SeasonChanged;
        event SeasonHandler MonthChanged;
    }
}
