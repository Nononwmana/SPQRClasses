using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriestGuy.Helpers
{
    internal class Spell
    {
        internal static bool CanCast(int spellId)
        {
            if(PriestGuy.currentSettings.StopCastingOnHighThreat
                && Anthrax.WoW.Internals.ObjectManager.Target.GetThreatEntry(Anthrax.WoW.Internals.ObjectManager.LocalPlayer).RawPercent >= 95)
                return false;

            return
                Anthrax.WoW.Internals.ActionBar.ContainsSpell(spellId)
                && Anthrax.WoW.Internals.ActionBar.IsSlotUsableByActionId(spellId)
                && Anthrax.WoW.Internals.Cooldown.GlobalCooldownTimeLeft(spellId) == 0
                && !Anthrax.WoW.Internals.Cooldown.IsSpellOnCooldown(spellId);

        }

        internal static void Cast(int spellId)
        {
            ExecuteSpell(spellId);

            int timeout = Environment.TickCount;

            while (!Anthrax.WoW.Internals.Spell.PendingCastSpell)
            {
                if (Environment.TickCount > (timeout + 500))
                    break;
                System.Threading.Thread.Sleep(10);
            }
        }

        internal static void CastOnUnit(int spellId, Anthrax.WoW.Classes.ObjectManager.WowUnit target, bool facetarget = false)
        {
            if (facetarget)
                Anthrax.WoW.Internals.Movements.Face(target.Position);

            if(target.SelectTarget())
            {
                ExecuteSpell(spellId);

                int timeout = Environment.TickCount;
                while (!Anthrax.WoW.Internals.Spell.PendingCastSpell)
                {
                    if (Environment.TickCount > (timeout + 500))
                        break;
                    System.Threading.Thread.Sleep(10);
                }
            }
        }
        private static void ExecuteSpell(int spellId)
        {
            var slots = Anthrax.WoW.Internals.ActionBar.GetSlots().Where(x => x.IsSpell && x.ActionId == spellId).ToList();

            if (slots.Count > 0)
            {
                Anthrax.WoW.Internals.ActionBar.PressSlotWithKeyboard(slots.First().BarIndex, slots.First().SlotIndex);
            }
        }

        internal static void StopCasting()
        {
            if (Anthrax.WoW.Internals.ObjectManager.LocalPlayer.IsCasting)
            {
                Anthrax.WoW.Internals.Bindings.ActionPress("MOVEFORWARD");
            }
        }
    }
}
