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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Nequeo.Threading.Extension
{
    public static partial class TaskFactoryExtensions
    {
        /// <summary>Asynchronously executes a sequence of tasks, maintaining a list of all tasks processed.</summary>
        /// <param name="factory">The TaskFactory to use to create the task.</param>
        /// <param name="functions">
        /// The functions that generate the tasks through which to iterate sequentially.
        /// Iteration will cease if a task faults.
        /// </param>
        /// <returns>A Task that will return the list of tracked tasks iterated.</returns>
        public static Task<IList<Task>> TrackedSequence(this TaskFactory factory, params Func<Task> [] functions)
        {
            var tcs = new TaskCompletionSource<IList<Task>>();
            factory.Iterate(TrackedSequenceInternal(functions, tcs));
            return tcs.Task;
        }

        /// <summary>Creates the enumerable to iterate through with Iterate.</summary>
        /// <param name="functions">
        /// The functions that generate the tasks through which to iterate sequentially.
        /// Iteration will cease if a task faults.
        /// </param>
        /// <param name="tcs">The TaskCompletionSource to resolve with the asynchronous results.</param>
        /// <returns>The enumerable through which to iterate.</returns>
        private static IEnumerable<Task> TrackedSequenceInternal(
            IEnumerable<Func<Task>> functions, TaskCompletionSource<IList<Task>> tcs)
        {
            // Store a list of all tasks iterated through.  This will be provided
            // to the resulting task when we're done.
            var tasks = new List<Task>();

            // Run seqeuentially through all of the provided functions.
            foreach (var func in functions)
            {
                // Get the next task.  If we get an exception while trying to do so,
                // an invalid function was provided.  Fault the TCS and break out.
                Task nextTask = null;
                try { nextTask = func(); } catch (Exception exc) { tcs.TrySetException(exc); }
                if (nextTask == null) yield break;

                // Store the task that was generated and yield it from the sequence.  If the task
                // faults, break out of the loop so that no more tasks are processed.
                tasks.Add(nextTask);
                yield return nextTask;
                if (nextTask.IsFaulted) break;
            }

            // We're done.  Transfer all tasks we iterated through.
            tcs.TrySetResult(tasks);
        }
    }
}