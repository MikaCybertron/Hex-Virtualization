using Hex.VM.Runtime.Util;
using System.Linq;

namespace Hex.VM.Runtime.Handler.Impl
{
    public class Not : HxOpCode
    {
        public override void Execute(Context vmContext, HxInstruction instruction)
        {
            var values = new object[] { vmContext.Stack.Pop().GetObject() };
            var result = Factory.CreateArithmethicFactory(HxOpCodes.ANot, values.Reverse().ToArray()); //Not Sure

            vmContext.Stack.Push(result);
            vmContext.Index++;
        }
    }
}