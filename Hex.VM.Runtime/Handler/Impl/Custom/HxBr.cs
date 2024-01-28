﻿using Hex.VM.Runtime.Util;

namespace Hex.VM.Runtime.Handler.Impl.Custom
{
    public class HxBr : HxOpCode
    {
        public override void Execute(Context vmContext, HxInstruction instruction) => vmContext.Index = (int)instruction.Operand.GetObject();
    }
}