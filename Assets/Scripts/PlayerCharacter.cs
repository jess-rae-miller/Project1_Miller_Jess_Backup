using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField] private int baseAttack = 10;
    [SerializeField] private int currentLevel = 1;
    [SerializeField] private int experienceThreshold = 100;

    private int attack;
    private int experience = 0;

    private void Start()
    {
        attack = baseAttack;
    }

    public void Attack(Enemy enemy)
    {
        enemy.TakeDamage(attack);
    }

    public void LevelUp()
    {
        currentLevel++;
        attack = (int)(attack * 1.2525f);
        experience = 0;
        experienceThreshold *= 2;

        if (currentLevel >= 5)
        {
            Debug.Log("Congratulations! Pluff has reached level 5 and defeated the Ghosts of his past!");
        }
        else
        {
            Debug.Log("Level up! Pluff is now level " + currentLevel + ". New attack value: " + attack);
        }
    }

    public void GainExperience(int amount)
    {
        experience += amount;
        Debug.Log("Pluff gained " + amount + " experience.");

        if (experience >= experienceThreshold)
        {
            LevelUp();
        }
    }
}