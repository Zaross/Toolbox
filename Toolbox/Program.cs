using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Toolbox
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string productName = GetProductName() ?? "Unknown Product";
            Console.WriteLine(productName);
            Mutex mutex = new Mutex(true, productName, out bool createdNew);
            if (!createdNew)
            {
                MessageBox.Show("Es läuft bereits eine Instanz.", productName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            Application.Run(new Mainframe());
        }

        /// <summary>
        /// Retrieves the product name from the assembly's product attribute.
        /// </summary>
        /// <returns>
        /// A string representing the product name if found; otherwise, "Unknown Product".
        /// </returns>
        private static string? GetProductName()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var productAttribute = (AssemblyProductAttribute?)Attribute.GetCustomAttribute(assembly, typeof(AssemblyProductAttribute));
            return productAttribute?.Product ?? "Unknown Product";
        }
    }
}