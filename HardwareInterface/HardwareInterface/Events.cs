﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInterface
{
    public delegate bool ReceiveNewPacketEvent(object sender, Packet packet);

    public delegate void TimeoutEvent(object sender, Packet packet);

    public delegate void ReceiveNewModBudResponse(object sender, ModBusResponse response);
}
