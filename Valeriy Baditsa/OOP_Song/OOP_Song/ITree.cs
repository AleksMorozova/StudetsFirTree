
namespace OOP_Song
{
    public interface ITree : IWildlife 
    {                        
        Figures Figure { get; }               
        void ChangeState(SeasonEventArgs e);
    }
}
