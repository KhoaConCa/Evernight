using System.Collections.Generic;
using UnityEngine;
using Vox.Interfaces;

namespace Vox.Ultilities.DesignPatterns.Factory
{
    /// <summary>
    /// Base Class PistolFactory - Developed by Duong Nhat Khoa on 2025/21/08.
    /// Purpose: This class serves as a base for all pistol factories in the game.
    /// </summary>
    public abstract class GunFactory<T> : MonoBehaviour where T : IRangedWeapon
    {
        public abstract T CreateGun();

        //#region --- Fields ---

        //private readonly Dictionary<string, T> _weaponRegistry = new();

        //#endregion

        //#region --- Methods ---

        //public void RegisterWeapon(string key, T weapon)
        //{
        //    if (!_weaponRegistry.ContainsKey(key))
        //        _weaponRegistry.Add(key, weapon);
        //}

        //public T GetWeapon(string key)
        //{
        //    return _weaponRegistry.TryGetValue(key, out var weapon) ? weapon : default;
        //}

        //#endregion
    }
}
