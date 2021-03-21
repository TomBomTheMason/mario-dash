using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Définit un obstacle présent dans le monde.
    ///              Définit les attributs communs à tous les obstacles.
    /// Date: 2021-03-20
    /// </summary>
    public class Obstacle : MonoBehaviour
    {
        #region Propriétés
        public string ObstacleName { get; set; }
        public GameObject ObstacleGameObject { get; set; }
        #endregion

        #region Main
        void Start()
        {

        }

        void Update()
        {

        }
        #endregion
    }
}
