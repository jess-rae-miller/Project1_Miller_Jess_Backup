using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    [SerializeField] private PlayerCharacter player;
    [SerializeField] private Enemy enemy;
    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (enemy != null)
            {
                player.Attack(enemy);
            }
        }
    }
}