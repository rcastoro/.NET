﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RuckusAlexaLibraryCore
{
    public interface IIntentRequest : IRequest
    {
        Intent Intent { get; set; }
    }
}
