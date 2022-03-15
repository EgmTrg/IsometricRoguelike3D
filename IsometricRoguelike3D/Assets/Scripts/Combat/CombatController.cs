using IsometricRoguelike.Input;
using UnityEngine;

namespace IsometricRoguelike.Combat
{
    public class CombatController : CombatBase
    {
        private void Update()
        {
            if (InputData.Combat.MeleeCombatKey)
                MeleeCombat();
            if (InputData.Combat.RangedCombatKey)
                RangedCombat();
        }

        protected override void MeleeCombat()
        {
            base.MeleeCombat();
        }

        protected override void RangedCombat()
        {
            // Fire2 butonu ile tetikleniyor.
            // Basildigi anda bir ok cikacak ve direction'u gosterecek.
            // Fire2 butonu birakildiginda ise projectile instantiate edilecek.

            base.RangedCombat();
        }
    }
}