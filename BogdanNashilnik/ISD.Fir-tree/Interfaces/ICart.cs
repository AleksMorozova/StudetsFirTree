namespace ISD.Fir_tree.Interfaces
{
    interface ICart : INamed
    {
        WheelsType WheelsType { get; set; }
        bool Put(INamed obj);
        void Remove();
    }
}
