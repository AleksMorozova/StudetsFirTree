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
        void SeasonChanged(YearsEventArgs e);
        void Grow();
    }
}
