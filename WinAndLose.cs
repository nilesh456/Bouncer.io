using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinAndLose : MonoBehaviour {

    public float restratDelay = 10f;
    
    float restartTimer;
    Animator anim;
    Movement player;
    EnemyMovement enemy;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        player = gameObject.GetComponent<Movement>();
        enemy = gameObject.GetComponent<EnemyMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!FindObjectOfType<Movement>())
        {
            anim.SetBool("Lose", true);

            restartTimer += Time.deltaTime;

            if (restartTimer >= restratDelay)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }

        if (!GameObject.FindGameObjectWithTag("Enemy"))
        {
            anim.SetBool("Win", true);
        }
	}
}
