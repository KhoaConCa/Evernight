using UnityEngine;
using Vox.Interfaces;
using Vox.Ultilities.Enums;

namespace Vox.Core.Pistols
{
    /// <summary>
    /// Base Class Pistol - Developed by Duong Nhat Khoa on 2025/08/21.
    /// Purpose: This class serves as a base for all pistol weapon types in the game.
    /// </summary>
    public abstract class Pistol : MonoBehaviour, IRangedWeapon, IWeaponStats
    {
        #region --- Implementation ---

        public string Initialize()
        {
            return $"{WeaponName} initialized.";
        }

        public virtual void Shoot()
        {
            Debug.Log("Bye!");
        }

        public virtual void Reload()
        {
            Debug.Log("Reloading...");
        }

        #endregion

        #region --- Properties ---

        public string WeaponName { get; set; }
        public int Damage { get; set; }
        public float FireRate { get; set; }
        public WeaponRange WeaponRange { get; set; }

        #endregion
    }
}
