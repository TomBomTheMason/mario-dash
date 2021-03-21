using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Weapons
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Contient les attributs communs à toutes les armes.
    /// Date: 2021-03-20
    /// </summary>
    public class Weapon : MonoBehaviour
    {
        #region Propriétés
        public string WeaponName { get; set; }
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
        private void HurtEnemy()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
