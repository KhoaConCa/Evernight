using UnityEngine;
using Vox.Ultilities.Enums;

namespace Vox.Interfaces
{
    /// <summary>
    /// Interface IWeaponStats - Developed by Duong Nhat Khoa on 2025/08/21.
    /// Purpose: This interface defines the basic stats for weapon in the game.
    /// </summary>
    public interface IWeaponStats
    {
        #region --- Properties ---

        string WeaponName { get; set; }
        int Damage { get; set; }
        float FireRate { get; set; }
        WeaponRange WeaponRange { get; set; }

        #endregion
    }
}
