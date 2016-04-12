using Spruce.Props;

namespace Spruce.Trees
{
    public interface IPlant
    {
         Colors Color
        {
            get;
        }
        Appearances Appearance
        {
            get;
        }
        int Hight
        {
            get;
        }
        void SeasonChanged(object sender, YearsEventArgs e);
        void Grow(object sender, YearsEventArgs e);
    }
}
