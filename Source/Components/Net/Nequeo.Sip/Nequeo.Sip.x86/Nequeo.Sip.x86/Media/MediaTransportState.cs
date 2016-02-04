﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2015 http://www.nequeo.com.au/
 * 
 *  File :          
 *  Purpose :       
 * 
 */

#region Nequeo Pty Ltd License
/*
    Permission is hereby granted, free of charge, to any person
    obtaining a copy of this software and associated documentation
    files (the "Software"), to deal in the Software without
    restriction, including without limitation the rights to use,
    copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the
    Software is furnished to do so, subject to the following
    conditions:

    The above copyright notice and this permission notice shall be
    included in all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
    EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
    OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
    NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
    HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
    WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
    FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
    OTHER DEALINGS IN THE SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nequeo.Net.Sip
{
    /// <summary>
    /// Enumeration of media transport state types.
    /// </summary>
    public enum MediaTransportState
    {
        /// <summary> 
        /// Null, this is the state before media transport is created. 
        /// </summary>
        PJSUA_MED_TP_NULL,
        /// <summary>
        /// Just before media transport is created, which can finish
        /// asynchronously later.
        /// </summary>
        PJSUA_MED_TP_CREATING,
        /// <summary> 
        /// Media transport creation is completed, but not initialized yet. 
        /// </summary>
        PJSUA_MED_TP_IDLE,
        /// <summary>
        /// Initialized (media_create() has been called). 
        /// </summary>
        PJSUA_MED_TP_INIT,
        /// <summary> 
        /// Running (media_start() has been called). 
        /// </summary>
        PJSUA_MED_TP_RUNNING,
        /// <summary>
        /// Disabled (transport is initialized, but media is being disabled). 
        /// </summary>
        PJSUA_MED_TP_DISABLED
    }
}
