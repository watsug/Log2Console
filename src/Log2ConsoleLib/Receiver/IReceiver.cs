using Log2ConsoleLib.Log;


namespace Log2ConsoleLib.Receiver
{
    public interface IReceiver
    {
        string SampleClientConfig { get; }
        string DisplayName { get; }

        void Initialize();
        void Terminate();

        void Attach(ILogMessageNotifiable notifiable);
        void Detach();
    }
}
