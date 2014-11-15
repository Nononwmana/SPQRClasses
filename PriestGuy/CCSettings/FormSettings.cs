using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriestGuy.Settings
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            FromSettings();
        }

        private void FormSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToSettings();
        }

        internal void ToSettings()
        {
            PriestGuy.currentSettings.UseShield = this.useShieldCheckBox.Checked;
            PriestGuy.currentSettings.UseShieldPercent = (int)this.useShieldNumeric.Value;
            PriestGuy.currentSettings.HealMyself = this.healMyselfCheckBox.Checked;
            PriestGuy.currentSettings.HealMyselfAt = (int)this.healMyselfNumeric.Value;
            PriestGuy.currentSettings.ResurrectNeabyPlayers = this.rezPlayersCheckBox.Checked;
            PriestGuy.currentSettings.StopCastingOnHighThreat = this.stopOnHighThreatCheckBox.Checked;
            PriestGuy.currentSettings.UseAOE = this.aoeCheckBox.Checked;
            PriestGuy.currentSettings.AOEAt = (int)this.aoeStartNumeric.Value;
           
        }

        internal void FromSettings()
        {
            this.useShieldCheckBox.Checked = PriestGuy.currentSettings.UseShield;
            this.useShieldNumeric.Value = PriestGuy.currentSettings.UseShieldPercent;
            this.healMyselfCheckBox.Checked = PriestGuy.currentSettings.HealMyself;
            this.healMyselfNumeric.Value = PriestGuy.currentSettings.HealMyselfAt;
            this.rezPlayersCheckBox.Checked = PriestGuy.currentSettings.ResurrectNeabyPlayers;
            this.stopOnHighThreatCheckBox.Checked= PriestGuy.currentSettings.StopCastingOnHighThreat;
            this.aoeCheckBox.Checked = PriestGuy.currentSettings.UseAOE;
            this.aoeStartNumeric.Value = PriestGuy.currentSettings.AOEAt;
        }
    }
}
