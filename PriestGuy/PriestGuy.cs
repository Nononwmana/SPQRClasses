using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anthrax.AI.Controllers;

namespace PriestGuy
{
    public class PriestGuy : Anthrax.Modules.ISPQR
    {

        public override string Name
        {
            get { return "PriestGuy"; }
        }

        public static CCSettings.Settings currentSettings = null;

        public static Anthrax.WoW.Classes.ObjectManager.WowLocalPlayer Me = Anthrax.WoW.Internals.ObjectManager.LocalPlayer;

        public static Dictionary<Anthrax.UInt128, int> RessurectBlacklist = new Dictionary<Anthrax.UInt128, int>();


        public override void OnCombat(Anthrax.WoW.Classes.ObjectManager.WowUnit unit)
        {
            if (Me.IsCasting 
                || Anthrax.WoW.Internals.Spell.PendingCastSpell)
                return;

            if(PriestGuy.currentSettings.ResurrectNeabyPlayers
                && Helpers.Spell.CanCast((int)Enums.Spells.Ressurection))
            {
                if (Me.IsAlliance)
                {
                    var playertoresurect = Anthrax.WoW.Internals.ObjectManager.GetObjectsOfType<Anthrax.WoW.Classes.ObjectManager.WowPlayer>().Where(x => x.IsAlliance && x.Position.Distance2DFromPlayer <= 30 && !x.IsAlive).First();
                    var oldTarget = unit;

                    if(!RessurectBlacklist.Where(pair => pair.Key == playertoresurect.GUID && Environment.TickCount - pair.Value < 60 * 1000).Any())
                    if (Helpers.Interact.MouseTarget(playertoresurect, true))
                    {
                        RessurectBlacklist.Add(playertoresurect.GUID, Environment.TickCount);
                        Helpers.Spell.CastOnUnit((int)Enums.Spells.Ressurection, playertoresurect, true);
                        Anthrax.WoW.Internals.Bindings.ActionPress("TARGETPREVIOUSENEMY");
                        Anthrax.WoW.Internals.Movements.Face(oldTarget.Position);

                        return;
                    }

                }
                else
                {
                    var playertoresurect = Anthrax.WoW.Internals.ObjectManager.GetObjectsOfType<Anthrax.WoW.Classes.ObjectManager.WowPlayer>().Where(x => x.IsHorde && x.Position.Distance2DFromPlayer <= 30 && !x.IsAlive).First();
                    var oldTarget = unit;

                    if (!RessurectBlacklist.Where(pair => pair.Key == playertoresurect.GUID && Environment.TickCount - pair.Value < 60 * 1000).Any())
                    if (Helpers.Interact.MouseTarget(playertoresurect, true))
                    {
                        RessurectBlacklist.Add(playertoresurect.GUID, Environment.TickCount);
                        Helpers.Spell.CastOnUnit((int)Enums.Spells.Ressurection, playertoresurect, true);
                        Anthrax.WoW.Internals.Bindings.ActionPress("TARGETPREVIOUSENEMY");
                        Anthrax.WoW.Internals.Movements.Face(oldTarget.Position);

                        return;
                    } 
                }
            }            

            if (Me.GetPower(Anthrax.WoW.Classes.ObjectManager.WowUnit.WowPowerType.ShadowOrbs) == 3
                && Helpers.Spell.CanCast((int)Enums.Spells.DevouringPlague))
            {
                Helpers.Spell.Cast((int)Enums.Spells.DevouringPlague);
                return;
            }

            if (Helpers.Spell.CanCast((int)Enums.Spells.SwDeath))
            {
                Helpers.Spell.Cast((int)Enums.Spells.SwDeath);
                return;
            }

            if (Helpers.Spell.CanCast((int)Enums.Spells.SwPain)
                && (lastSwPain + 1000 < Environment.TickCount)
                && (!unit.Auras.Where(aura => aura.SpellId == (int)Enums.Auras.SwPain).Any()
                    || unit.Auras.Where(aura => aura.SpellId == (int)Enums.Auras.SwPain && aura.CasterGUID != Me.GUID).Any())
                    || unit.Auras.Where(aura => aura.SpellId == (int)Enums.Auras.SwPain && aura.CasterGUID == Me.GUID && aura.TimeLeft <= 3000).Any())

            {
                lastSwPain = Environment.TickCount;
                Helpers.Spell.Cast((int)Enums.Spells.SwPain);
                return;
            }

            if (Helpers.Spell.CanCast((int)Enums.Spells.VampiricTouch)
                && (lastVampiticTouch + 1000 < Environment.TickCount)
                && (!unit.Auras.Where(aura => aura.SpellId == (int)Enums.Auras.VampiricTouch).Any()
                    || unit.Auras.Where(aura => aura.SpellId == (int)Enums.Auras.VampiricTouch && aura.CasterGUID != Me.GUID).Any())
                    || unit.Auras.Where(aura => aura.SpellId == (int)Enums.Auras.VampiricTouch && aura.CasterGUID == Me.GUID && aura.TimeLeft <= 5000).Any())
            {
                lastVampiticTouch = Environment.TickCount;
                Helpers.Spell.Cast((int)Enums.Spells.VampiricTouch);
                return;
            }

            else if (Helpers.Spell.CanCast((int)Enums.Spells.MindBlast))
            {
                Helpers.Spell.Cast((int)Enums.Spells.MindBlast);
                return;
            }

            if (PriestGuy.currentSettings.UseAOE
                && Helpers.Spell.CanCast((int)Enums.Spells.MindSear)
                && Anthrax.WoW.Internals.ObjectManager.GetObjects().Where(x =>
                    x.Position.Distance2D(unit.Position) <= 10
                    && x.Type != Anthrax.WoW.Classes.ObjectManager.WowUnit.WowObjectType.Player
                    ).Count() >= PriestGuy.currentSettings.AOEAt)
            {
                Helpers.Spell.Cast((int)Enums.Spells.MindSear);
                return;
            }

            if (Helpers.Spell.CanCast((int)Enums.Spells.MindFlay))
            {
                Helpers.Spell.Cast((int)Enums.Spells.MindFlay);
                return;
            }

        }

        int lastSwPain = 0;
        int lastVampiticTouch = 0;

        public override void Settings()
        {
            new Settings.FormSettings().ShowDialog();            
        }

        public override void OnLoad()
        {
            CCSettings.IO.Load();
        }

        public override void OnUnload()
        {
            CCSettings.IO.Save();
        }
    }
}
