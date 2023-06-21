using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int level = 1;
    public int baseMaxHP = 10;
    public int maxLevel = 5;

    private int maxHP;
    private int currentHP;

    [SerializeField] private PlayerCharacter player;
    private void Start()
    {
        maxHP = baseMaxHP * level;
        currentHP = maxHP;
        Debug.Log("A level " + level + " Ghost has appeared! HP: " + currentHP);
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        Debug.Log("Pluff dealt " + damage + " damage to the Ghost.  HP: " + currentHP);

        if (currentHP <= 0)
        {
            EnemyDefeated();
        }
    }

    private void EnemyDefeated()
    {

        if (player != null)
        {
            player.GainExperience(Random.Range(1, 30));
        }

        if (level < maxLevel)
        {
            level++;
            maxHP = baseMaxHP * level;
        }
        currentHP = maxHP;
        Debug.Log("Ghost defeated! What's that?! A level " + level + " Ghost has appeared! HP: " + currentHP);
    }
}