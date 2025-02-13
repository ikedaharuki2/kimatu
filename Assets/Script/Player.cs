using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    int hp = 10;
    public GameObject Bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(0, 0.01f, 0);

        if(Input.GetKey(KeyCode.S))
            transform.Translate(0, -0.01f, 0);

        if(Input.GetKey(KeyCode.A))
            transform.Translate(-0.01f, 0, 0);

        if(Input.GetKey(KeyCode.D))
            transform.Translate(0.01f, 0, 0);

        if(Input.GetKeyDown(KeyCode.Space))
            Instantiate(Bullet,transform.position,Quaternion.identity);

        if (hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Destroy(gameObject);
        }
    }
    public void Damege()
    {
        --hp;
    }
}
