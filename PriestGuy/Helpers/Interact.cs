using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriestGuy.Helpers
{
    internal class Interact
    {
        internal static bool MouseTarget(Anthrax.WoW.Classes.ObjectManager.WowObject wowobject, bool facewowobject = false)
        {
            if (Anthrax.WoW.Internals.ObjectManager.Target.GUID == wowobject.GUID)
                return true;

            if(facewowobject)
            {
                Anthrax.WoW.Internals.Movements.StopMove();
                Anthrax.WoW.Internals.Movements.Face(wowobject.Position);
            }

            System.Drawing.Point screenPos = new System.Drawing.Point();

            if (Anthrax.WoW.Internals.WorldFrame.ActiveCamera.WorldToScreen(wowobject.Position, ref screenPos))
            {
                Anthrax.WoW.Internals.MouseController.MoveMouse(screenPos.X, screenPos.Y);
                Anthrax.WoW.Internals.MouseController.LeftClick();
                System.Threading.Thread.Sleep(150);
            }

            return Anthrax.WoW.Internals.ObjectManager.Target.GUID == wowobject.GUID;
        }

        internal static bool MouseInteract(Anthrax.WoW.Classes.ObjectManager.WowObject wowobject, bool facewowobject = false)
        {
            if (Anthrax.WoW.Internals.ObjectManager.Target.GUID == wowobject.GUID)
                return true;

            if (facewowobject)
            {
                Anthrax.WoW.Internals.Movements.StopMove();
                Anthrax.WoW.Internals.Movements.Face(wowobject.Position);
            }

            System.Drawing.Point screenPos = new System.Drawing.Point();

            if (Anthrax.WoW.Internals.WorldFrame.ActiveCamera.WorldToScreen(wowobject.Position, ref screenPos))
            {
                Anthrax.WoW.Internals.MouseController.MoveMouse(screenPos.X, screenPos.Y);
                Anthrax.WoW.Internals.MouseController.RightClick();
                System.Threading.Thread.Sleep(150);
            }

            return Anthrax.WoW.Internals.ObjectManager.Target.GUID == wowobject.GUID;
        }
    }
}
