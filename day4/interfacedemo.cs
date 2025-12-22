using System;
namespace InterfaceDemoProj
{
    interface IAdd//first letter in interface is always capital
{
    //by default all methods in interface are abstract
    int AddMe(int num1, int num2);
}
interface ISub//first letter in interface is always capital
{
    //by default all methods in interface are abstract
    int SubMe(int num1, int num2);
}

interface IProd//first letter in interface is always capital
{
    //by default all methods in interface are abstract
    int ProdMe(int num1, int num2);
}
interface IDiv//first letter in interface is always capital
{
    //by default all methods in interface are abstract
    int DivMe(int num1, int num2);//for every class n interface there should be a seperate file , but here we r doing a bit bit work so not required
}

interface IAddSub : IAdd, ISub//one interface can implement another interface as well
    {
        
    }
    interface IAddProdDiv : IAdd, IProd, IDiv
    {
        
    }
    interface IAll:IAddSub,IAddProdDiv,ISub
    {
        
    }

}