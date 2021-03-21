using Assets.Scripts.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.World
{
    /// <summary>
    /// Auteur: Alexis Harrington
    /// Description: Déclare les attributs communs à tous les obstacles qui font perdre de la vie au joueur.
    /// Date: 2021-03-20
    /// </summary>
    public interface IHarmfulObstacle
    {
        HealthManager HealthManager { get; set; }
        int Damage { get; set; }

        /// <summary>
        /// Fait appel au HealthManager pour faire perdre de la vie au joueur.
        /// </summary>
        void HurtPlayerOnContact();
    }
}
