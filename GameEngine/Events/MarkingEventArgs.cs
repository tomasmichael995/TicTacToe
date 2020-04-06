﻿//-----------------------------------------------------------------------------

using System;

//-----------------------------------------------------------------------------

namespace GameEngine.Events {

//-----------------------------------------------------------------------------

public class MarkingEventArgs : EventArgs{

//-----------------------------------------------------------------------------

public Marking Marking { get; set; }

// ----------------------------------------------------------------------------

public MarkingEventArgs(
  Marking marking)
{
  Marking = marking;
}

// ----------------------------------------------------------------------------

} // <-- end of type body -->

// ----------------------------------------------------------------------------

} // <-- end of namespace body -->
