﻿namespace rsc
{
  class Program
  {
    static void Main(string[] args)
    {
      NFX.PAL.NetFramework.DotNetFrameworkRuntime.Init();
      NFX.Tools.Rsc.ProgramBody.Main(args);
    }
  }
}
