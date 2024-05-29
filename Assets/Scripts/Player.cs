using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using 

public class Player : MonoBehaviour
{
    public static Player instance;
    public int coins;
    public int health;
    private TextMeshProUGUI coinsText;
    private image coinsImage;
    private TextMeshProUGUI healthText;
    private image healthImage;


    private void Start()
    {
        if (instance == null)
            instance = this;
        
        coins = 0;
        health = 100;
    }

    public void ChangeHp(int amount)
    {
        health += amount;
        healthText.text = health + "";
        ShowInfo();
    }

    public void ChangeCoins(int amount)
    {
        coins += amount;
        coinsText.text = coins + "";
        ShowInfo();
    }
    public void 
}
