using System.Windows.Forms;


namespace Log2ConsoleLib.Log
{
    /// <summary>
    /// 
    /// </summary>
    public interface ILogManager
    {
        /// <summary>
        /// Initializes the log manager with the specified logger view.
        /// </summary>
        /// <param name="loggerView">The logger view.</param>
        /// <param name="logListView">The log list view.</param>
        void Initialize(ILoggerView loggerView, ListView logListView);

        /// <summary>
        /// Clears all loggers and messages managed by the log manager.
        /// </summary>
        void ClearAll();

        /// <summary>
        /// Clears the all log messages managed by the log manager.
        /// </summary>
        void ClearLogMessages();

        /// <summary>
        /// Processes the log message.
        /// </summary>
        /// <param name="logMsg">The log MSG.</param>
        void ProcessLogMessage(LogMessage logMsg);

        /// <summary>
        /// Search for text.
        /// </summary>
        /// <param name="str">The string to search.</param>
		void SearchText(string str);

        /// <summary>
        /// Updates the log level.
        /// </summary>
        void UpdateLogLevel();

        /// <summary>
        /// Sets the name of the root logger.
        /// </summary>
        /// <param name="name">The name.</param>
        void SetRootLoggerName(string name);
    }
}
