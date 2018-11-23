

namespace MultiPlug.Ext.QRCoder
{
    public class Core
    {
        private static Core m_Instance = null;

        public static Core Instance
        {
            get
            {
                if (m_Instance == null)
                {
                    m_Instance = new Core();
                }
                return m_Instance;
            }
        }
    }
}
