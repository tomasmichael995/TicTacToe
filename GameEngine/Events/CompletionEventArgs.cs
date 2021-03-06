﻿//-----------------------------------------------------------------------------

using System;

//-----------------------------------------------------------------------------

namespace GameEngine.Events {

//-----------------------------------------------------------------------------

public class CompletionEventArgs : EventArgs{

//-----------------------------------------------------------------------------

public Result Result { get; set; }

// ----------------------------------------------------------------------------

public CompletionEventArgs(
  Result result)
{
  Result = result;
}

// ----------------------------------------------------------------------------

} // <-- end of type body -->

// ----------------------------------------------------------------------------

} // <-- end of namespace body -->

