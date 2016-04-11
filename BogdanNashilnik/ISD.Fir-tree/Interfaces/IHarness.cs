namespace ISD.Fir_tree.Interfaces
{
    interface IHarness
    {
        ICart Cart { get; }
        void PutCart(ICart cart);
        void RemoveCart();
    }
}
