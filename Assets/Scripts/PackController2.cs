using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackController2 : MonoBehaviour
{
    AudioSource aud;
    public AudioClip MyGoalSE;
    public AudioClip EnemyGoalSE;

    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        //AudioSourceコンポーネント取得
        this.aud = GetComponent<AudioSource>();

        this.director = GameObject.Find("GameDirector");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Maret"))
        {
            Debug.Log("Maret");
        }
        else if (other.CompareTag("MyGoal"))
        {
            this.aud.PlayOneShot(this.MyGoalSE);
        }
        else if (other.CompareTag("EnemyGoal"))
        {
            this.aud.PlayOneShot(this.EnemyGoalSE);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MyGoal"))
        {
            this.director.GetComponent<GameDirector>().EnterMyGoal();
            Destroy(gameObject);
        }
        else if (other.CompareTag("EnemyGoal"))
        {
            this.director.GetComponent<GameDirector>().EnterEnemyGoal();
            Destroy(gameObject);
        }
    }
}
