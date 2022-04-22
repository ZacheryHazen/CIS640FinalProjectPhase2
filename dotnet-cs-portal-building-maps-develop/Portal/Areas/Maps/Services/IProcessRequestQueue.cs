/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ksu.Cs.Portal.Areas.Maps.Services 
{
    public interface IProcessRequestQueue
    {
        /// <summary>
        /// Adds a process request to the queue to be processed at a future point
        /// </summary>
        /// <param name="request">The process request to process</param>
        /// <returns>A task that resolves when the process request is written to the queue</returns>
        ValueTask EnqueueAsync(ProcessRequest request);

        /// <summary>
        /// Removes a process request from the queue for processed
        /// </summary>
        /// <returns>A task representing the process request</returns>
        ValueTask<ProcessRequest> DequeueAsync(CancellationToken cancellationToken);
    }
}