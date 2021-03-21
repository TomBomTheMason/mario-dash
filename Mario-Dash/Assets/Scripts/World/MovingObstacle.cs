using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Définit un obstacle présent dans le monde.
    ///              Est un obstacle qui bouge (IMovingObstacle).
    /// Date: 2021-03-20
    /// </summary>
    public class MovingObstacle : Obstacle, IMovingObstacle
    {
        #region Propriétés
        public float MovementSpeed { get; set; }
        public Vector2 StartingPosition { get; set; }
        public Vector2 EndingPosition { get; set; }
        public IMovingObstacle.MovementTypes MovementType { get; set; }
        public bool Loop { get; set; }
        #endregion

        #region Main
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion

        #region Méthodes
        public void Move(GameObject obstacle)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
