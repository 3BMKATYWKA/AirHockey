using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject text_MyPoint;
    GameObject text_EnemyPoint;
    int num_MyPoint = 0;
    int num_EnemyPoint = 0;

    void Start()
    {
        this.text_MyPoint = GameObject.Find("MyPoint");
        this.text_EnemyPoint = GameObject.Find("EnemyPoint");

    }

    void Update()
    {
        this.text_MyPoint.GetComponent<Text>().text = "My Point : " + this.num_MyPoint.ToString();
        this.text_EnemyPoint.GetComponent<Text>().text = "Enemy Point : " + this.num_EnemyPoint.ToString();
    }

    public void EnterMyGoal()
    {
        num_EnemyPoint += 1;
    }

    public void EnterEnemyGoal()
    {
        num_MyPoint += 1;
    }
}
