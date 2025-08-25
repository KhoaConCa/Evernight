using UnityEngine;
using Vox.Core.Pistols;
using Vox.Interfaces;

namespace Vox.Ultilities.DesignPatterns.Factory
{
    /// <summary>
    /// PistolTypeFactory - Developed by Duong Nhat Khoa on 2025/21/08.
    /// Purpose: This class serves as a factory for creating pistol types in the game.
    /// </summary>
    public class PistolTypeFactory : GunFactory<IRangedWeapon>
    {
        #region --- Overrides ---

        public override IRangedWeapon CreateGun()
        {
            var gunInstance = Instantiate(_gunPrefab);
            gunInstance.name = _gunPrefab.name;
            return gunInstance;
        }

        #endregion

        #region --- Fields ---

        [SerializeField] private Pistol _gunPrefab;

        #endregion
    }
}
