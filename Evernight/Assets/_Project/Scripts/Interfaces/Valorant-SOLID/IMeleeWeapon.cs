using UnityEngine;

namespace Vox.Interfaces
{
    /// <summary>
    /// Interface IMeleeWeapon - Developed by Duong Nhat Khoa on 2025/08/21.
    /// Purpose: This class serves as a base for all melee weapon functions in the game.
    /// </summary>
    public interface IMeleeWeapon
    {
        #region --- Methods ---

        void NormalAttack();
        void HeavyAttack();

        #endregion
    }
}
