using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Déclare les attributs communs à tous les obstacles qui bougent.
    /// Date: 2021-03-20
    /// </summary>
    public interface IMovingObstacle
    {
        /// <summary>
        /// Décrit les types de mouvement possibles.
        ///     - Normal: Le mouvement se fait de StartingPosition à EndingPosition.
        ///     - Alternate: Le mouvement se fait de StartingPosition à EndingPosition, puis revient.
        /// </summary>
        public enum MovementTypes
        {
            Normal,
            Alternate
        }

        float MovementSpeed { get; set; }
        Vector2 StartingPosition { get; set; }
        Vector2 EndingPosition { get; set; }
        MovementTypes MovementType { get; set; }
        bool Loop { get; set; }

        /// <summary>
        /// Déclenche le mouvement d'un obstacle selon le type de mouvement et la vitesse.
        /// </summary>
        /// <param name="obstacle">L'obstacle qui bougera</param>
        void Move(GameObject obstacle);
    }
}
