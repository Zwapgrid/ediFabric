﻿//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

namespace EdiFabric.Core.Model.Ack
{
    /// <summary>
    /// Control the generation of TA1.
    /// </summary>
    public enum TechnicalAck
    {
        /// <summary>
        /// Enforce the generation of technical acknowledgment.
        /// </summary>
        Enforce,
        /// <summary>
        /// Generate according to the ISA14 flag (for X12) or UNB9 flag (for EDIFACT). 
        /// </summary>
        Default,
        /// <summary>
        /// Suppress the generation of technical acknowledgment.
        /// </summary>
        Suppress
    }
}
