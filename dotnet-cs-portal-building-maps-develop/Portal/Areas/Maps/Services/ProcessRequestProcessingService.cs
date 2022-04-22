/*
* Licensed under the MIT License, see LICENSE file for details.
*/

using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Ksu.Cs.Portal.Areas.Maps.Services
{
    /// <summary>
    /// A service that processes ProcessRequests in the background
    /// </summary>
    public class ProcessRequestProcessingService : BackgroundService
    {
        private readonly IProcessRequestQueue _queue;

        /// <summary>
        /// Constructs a new instance of ProcessRequestProcessingService
        /// </summary>
        /// <param name="queue">The queue of ProcessRequests</param>
        public ProcessRequestProcessingService(IProcessRequestQueue queue)
        {
            _queue = queue;
        }

        /// <summary>
        /// Starts the background processing service
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to signal a stop for the service</param>
        /// <returns>A task that resolves once the background processing service has launched</returns>
        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            await BackgroundProcessing(cancellationToken);
        }

        /// <summary>
        /// Signals a stop to the background processing (which waits for current tasks to finish)
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to signal a stop to the stop requests</param>
        /// <returns>A task that resolves once the service stops</returns>
        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await base.StopAsync(cancellationToken);
        }

        /// <summary>
        /// The background processing loop
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to signal a stop to the background processing</param>
        /// <returns>A task that resolves once the background processing ends</returns>
        private async Task BackgroundProcessing(CancellationToken cancellationToken)
        {
            while(!cancellationToken.IsCancellationRequested) 
            {
                // Pop the latest request off of the queue
                var request = await _queue.DequeueAsync(cancellationToken);

                // Open StreamReader that reads the temporary file path
                using var stream = new StreamReader(File.OpenRead(request.FilePath));

                // Asyncronously read the data
                string body = await stream.ReadToEndAsync();

                // Use regex to count the number of pages in the pdf
                Regex regex = new Regex(@"/Type\s*/Page[^s]");
                MatchCollection matches = regex.Matches(body);

                Console.WriteLine("Number of pages: " + matches.Count);

                // This should be were we put the processing logic
            }
        }
    }
}
