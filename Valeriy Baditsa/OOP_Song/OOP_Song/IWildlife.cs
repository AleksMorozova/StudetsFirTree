
namespace OOP_Song
{    
    public interface IWildlife
    {
        string Name { get; set; }
        Colors color { get; }
        double Hight { get; set; }

        void Grow();
    }
}
