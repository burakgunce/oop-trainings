namespace Araclar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperationManager operationManager = new OperationManager(new ElektrikliArac());
            operationManager.YakıtTipi();

            OperationManager operationManager2 = new OperationManager(new BenzinliArac());
            operationManager2.YakıtTipi();
        }
    }
}