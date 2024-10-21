using System;
public class HealthSystem
{
    // Variables
    public int health;
    public string healthStatus;
    public int shield;
    public int lives = 3;
    

    // Optional XP system variables
    public int xp;
    public int level;


   

    public HealthSystem()
    {
        ResetGame();
    }


    public string ShowHUD()
    {   
        healthStatus = HealthStatus(health);
        return $"Health: {health}" + $" Shield: {shield}" + $" Lives: {lives}" + $" HealthStatus: {healthStatus}";
    }

    public void TakeDamage(int damage)
    {
        
        if(shield <= 0)
        {
            int remainingDamage = shield;
           
            if(damage > shield)
            {
                shield = 0;
                health = health + remainingDamage;
            }
           
            if (health <= 0)
            {
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
        if (hp <= 100)
        {
            return "Perfect Health";
        }
        else if (hp <= 90)
        {
            return "Healthy";
        }
        else if (hp <= 75)
        {
            return "Hurt";
        }
        else if (hp <= 50)
        {
            return "Badly Hurt";
        }
        else
        {
            return "Imminent Danger";
        }
    
        
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
    }

    public void ResetGame()
    {
        health = 100;
        shield = 100;
        lives = 3;
        
    }

    
    public void IncreaseXP(int exp)
    {
          
    }
}