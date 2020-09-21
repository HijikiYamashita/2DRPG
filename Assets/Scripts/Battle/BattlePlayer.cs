using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayer : MonoBehaviour
{
    public static int playerHP = 10;
    public static int playerATK = 10;
    public static int playerDEF = 10;

    int damage;
    int basicDamage;
    int randomDamage;
    int random;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            attack();
        }
    }

    void attack()
    {
        Debug.Log(BattleEnemy.enemyHP);
        basicDamage = playerATK / 2 - BattleEnemy.enemyDEF / 4;
        randomDamage = basicDamage / 16;
        random = Random.Range(0, 101);
        if (random <= 50)
        {
            damage = basicDamage + Random.Range(0, randomDamage + 1);
        }
        if (random >= 51)
        {
            damage = basicDamage - Random.Range(0, randomDamage + 1);
        }
        BattleEnemy.enemyHP = BattleEnemy.enemyHP - damage;
        Debug.Log(BattleEnemy.enemyHP);
    }
}
