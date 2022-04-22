/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ksu.Cs.Portal.Areas.Maps.Services
{
    /// <summary>
    /// A threadsafe queue for enqueueing and dequeueing process requests
    /// so that they can be processed in a background thread
    /// </summary>
    public class ProcessRequestQueue : IProcessRequestQueue
    {
        private readonly Channel<ProcessRequest> _queue;

        /// <summary>
        /// Creates a new ProcessRequestQueue
        /// </summary>
        /// <param name="capacity">The number of ProcessReqeusts the queue can hold</param>
        public ProcessRequestQueue(int capacity)
        {
            var options = new BoundedChannelOptions(capacity)
            {
                FullMode = BoundedChannelFullMode.Wait
            };
            _queue = Channel.CreateBounded<ProcessRequest>(options);
        }

        /// <summary>
        /// Enqueues a process request for future processing
        /// </summary>
        /// <param name="processRequest">The request to add to the queue</param>
        /// <returns>A task that resolves once the request is added to the queue</returns>
        public async ValueTask EnqueueAsync(ProcessRequest processRequest)
        {
            if (processRequest == null) throw new ArgumentNullException(nameof(processRequest));
            await _queue.Writer.WriteAsync(processRequest);
        }

        /// <summary>
        /// Removes the oldest ProcessRequest from the queue for processing
        /// </summary>
        /// <param name="cancellationToken">A cancellation token</param>
        /// <returns>A task resolving to the processRequest</returns>
        public async ValueTask<ProcessRequest> DequeueAsync(CancellationToken cancellationToken)
        {
            var processRequest = await _queue.Reader.ReadAsync(cancellationToken);
            return processRequest;
        }
    }
}