using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Gère la vie du joueur.
    /// Date: 2021-03-21
    /// </summary>
    public class HealthManager : MonoBehaviour
    {
        #region Propriétés
        public int Health { get; set; }
        public int MaxHealth { get; set; }
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
        public void HurtPlayer(int damage)
        {
            Health -= damage;

            // ...
        }
        #endregion
    }
}
