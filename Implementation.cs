namespace Implementation
{
    public class Logger
    {
        private static readonly Lazy<Logger> _logger = new Lazy<Logger>(() => new Logger());
        // private static Logger? _instance;
        private Logger()
        {
            Console.WriteLine("Called to Constructor and create an instance");
        }

        public static Logger Instance
        {
            get
            {
                Console.WriteLine("Called to Instance");
                return _logger.Value;
                // if (_instance == null)
                // {
                //     _instance = new Logger();
                // }
                // return _instance;
            }
        }
    }
}