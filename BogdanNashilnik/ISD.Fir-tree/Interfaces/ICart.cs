namespace ISD.Fir_tree.Interfaces
{
    interface ICart : IHaveName
    {
        WheelsType WheelsType { get; set; }
        bool Put(IHaveName obj);
        void Remove();
    }
}
