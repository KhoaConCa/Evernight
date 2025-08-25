using UnityEngine;
using Vox.Interfaces;
using Vox.Ultilities.Enums;

namespace Vox.Core.Pistols
{
    /// <summary>
    /// Class Classic - Developed by Duong Nhat Khoa on 2025/08/21.
    /// Purpose: This class represents the Classic pistol in the game, inheriting from the Pistol base class.
    /// </summary>
    public class Classic : Pistol
    {
        #region --- Constructor ---

        public Classic()
        {
            WeaponName = "Classic";
            Damage = 40;
            FireRate = 0.5f;
            WeaponRange = WeaponRange.Medium;
        }

        #endregion

        #region --- Overrides ---

        public override void Shoot()
        {
            Debug.Log($"{WeaponName} fired with {Damage} damage at a rate of {FireRate} seconds.");
        }

        public override void Reload()
        {
            Debug.Log($"{WeaponName} reloading...");
        }

        #endregion
    }
}
