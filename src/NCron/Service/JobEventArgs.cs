using System;

namespace NCron.Service
{
    /// <summary>
    /// Event argument for Job events.
    /// </summary>
    public class JobEventArgs : EventArgs
    {
        /// <summary>
        /// The job related to the event.
        /// </summary>
        public ICronJob Job { get; private set; }

        public JobEventArgs(ICronJob job)
        {
            Job = job;
        }
    }
}
