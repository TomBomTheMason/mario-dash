using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Définit un obstacle présent dans le monde.
    ///              Est un obstacle qui bouge (MovingObstacle).
    ///              Est un obstacle qui fait perdre de la vie au joueur (HarmfulObstacle).
    /// Date: 2021-03-20
    /// </summary>
    public class MovingHarmfulObstacle : Obstacle
    {
        #region Champs
        private MovingObstacle _movingObstacle = new MovingObstacle();
        private HarmfulObstacle _harmfulObstacle = new HarmfulObstacle();
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
        public void Move()
        {
            _movingObstacle.Move(gameObject);
        }

        public void HurtPlayerOnContact()
        {
            _harmfulObstacle.HurtPlayerOnContact();
        }
        #endregion
    }
}
