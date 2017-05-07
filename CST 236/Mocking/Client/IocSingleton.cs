using System.Configuration;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;


namespace Client
{
    public class IoC
    {
        static IUnityContainer Container;

        static void RegisterIoC()
        {
            UnityConfigurationSection section = ConfigurationManager.GetSection("unity") as UnityConfigurationSection;
            if (section != null)
            {
                section.Configure(Container);
            }
        }

        public static IUnityContainer GetInstance()
        {
            if (Container == null)
            {
                Container = new UnityContainer();
                RegisterIoC();
            }

            return Container;
        }
    }
}
