using UnityEngine;

namespace Vox.Interfaces
{
    /// <summary>
    /// Interface IRangedWeapon - Deveploped by Duong Nhat Khoa on 2025/08/21.
    /// Purpose: This class serves as a base for ranged weapon functions in the game.
    /// </summary>
    public interface IRangedWeapon
    {
        #region --- Methods ---

        /// <summary>
        /// Initialize the weapon with a specific type.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Executes a shooting action.
        /// </summary>
        void Shoot();

        /// <summary>
        /// Executes a reloading action.
        /// </summary>
        void Reload();

        #endregion
    }
}
