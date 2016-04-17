
namespace OOP_Song
{
    public interface ITree : IWildlife 
    {                        
        Figures Figure { get; }               
        void reactionTreeOn_SezonChanged(SeasonEventArgs e);
    }
}
