using System;
using UnityEngine;
public class HealthSystem
{
    // Variables
    public int health;
    public string healthStatus;
    public int shield;
    public int lives = 3;


    // Optional XP system variables
    public int xp = 0;
    public int level = 1;




    public HealthSystem()
    {
        ResetGame();
    }


    public string ShowHUD()
    {
        healthStatus = HealthStatus(health);
        return $"Health: {health}" + $" Shield: {shield}" + $" Lives: {lives}" + $" HealthStatus: {healthStatus}" + $"Level: {level}";
    }

    public void TakeDamage(int damage)
    {

        if (damage > shield)
        {
            damage = damage - shield;
            shield = 0;
            health = health - damage;

            if (health <= 0)
            {
                health = 0;
                Revive();
            }
        }
        else
        {
            shield = shield - damage;
        }

    }

    public void Heal(int hp)
    {
        health = health + hp;
    }

    public string HealthStatus(int hp)
    {
        if (hp <= 100 && hp > 90)
        {
            return "Perfect Health";
        }
        else if (hp <= 90 && hp > 75)
        {
            return "Healthy";
        }
        else if (hp <= 75 && hp > 50)
        {
            return "Hurt";
        }
        else if (hp <= 50 && hp > 10)
        {
            return "Badly Hurt";
        }
        else if (hp <= 10 && hp >= 1)
        {
            return "Imminant Danger";
        }

        return "Out of Range";
        
    }

    public void RegenerateShield(int hp)
    {
        shield = shield + hp; 
    }

    public void Revive()
    {
      
        lives = lives - 1;
        health = 100;
        shield = 100;

       if(lives <= 0)
        {
            ResetGame();
        }
    }

    public void ResetGame()
    {
        health = 100;
        shield = 100;
        lives = 3;
        level = 1;
        xp = 0;
    }

   

    public void IncreaseXP(int exp)
    {
        
        level = level + exp;


    }

   







}