using UnityEngine;

namespace Vox.Interfaces
{
    /// <summary>
    /// Interface IScopeable - Deveploped by Duong Nhat Khoa on 2025/08/21.
    /// Purpose: This class serves as a base for all weapon have scope in the game.
    /// </summary>
    public interface IScopeable
    {
        #region --- Methods ---

        void ZoomIn();
        void ZoomOut();

        #endregion
    }
}