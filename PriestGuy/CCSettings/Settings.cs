using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace PriestGuy.CCSettings
{
    [Serializable]
    public class Settings
    {
        public bool HealMyself = true;
        public int HealMyselfAt = 30;

        public bool UseShield = true;
        public int UseShieldPercent = 50;

        public bool StopCastingOnHighThreat = false;
        public bool ResurrectNeabyPlayers = true;

        public bool UseAOE = true;
        public int AOEAt = 2;
    }

    public class IO
    {
        public static void Save()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                using (StreamWriter wr = new StreamWriter("Combats\\SPQR\\PriestGuy\\Settings.xml"))
                {
                    xs.Serialize(wr, PriestGuy.currentSettings);
                }
            }
            catch { }
        }
        public static void Load()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Settings));
                using (StreamReader rd = new StreamReader("Combats\\SPQR\\PriestGuy\\Settings.xml"))
                {
                    PriestGuy.currentSettings = xs.Deserialize(rd) as Settings;
                }
            }
            catch { }
            finally
            {
                if (PriestGuy.currentSettings == null)
                    PriestGuy.currentSettings = new Settings();
            }
        }
    }

    
}
