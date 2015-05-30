﻿/*  Company :       Nequeo Pty Ltd, http://www.nequeo.com.au/
 *  Copyright :     Copyright © Nequeo Pty Ltd 2010 http://www.nequeo.com.au/
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
using System.Data;

namespace Nequeo.Serialisation.Extension
{
    /// <summary>
    /// Class that extends the System.Data.DataTable type.
    /// </summary>
    public static class DataTableExtensions
    {
        /// <summary>
        /// Serialise the current data table
        /// </summary>
        /// <param name="source">The current data table source.</param>
        /// <returns>The byte array of serialised data.</returns>
        public static byte[] Serialise(this DataTable source)
        {
            DataTableSerialisation seril = new DataTableSerialisation();
            return seril.Serialise(source);
        }

        /// <summary>
        /// Deserialise the current data table
        /// </summary>
        /// <param name="source">The current data table source.</param>
        /// <param name="serialisedData">The serialised data.</param>
        /// <returns>The deserialised data table.</returns>
        public static DataTable Deserialise(this DataTable source, byte[] serialisedData)
        {
            DataTableSerialisation seril = new DataTableSerialisation();
            return seril.Deserialise(serialisedData);
        }
    }
}