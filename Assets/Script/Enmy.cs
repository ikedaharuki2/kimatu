using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmy : MonoBehaviour
{
    public GameObject EnmyBullet;
    int hp = 5;
    float x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += 0.002f;

        if(x >= 1)
        {
            Instantiate(EnmyBullet, transform.position, Quaternion.identity);
            x = 0;
        }

        if (transform.position.x > 7)
            transform.Translate(-0.01f, 0, 0);

        if (hp <= 0)
        {
            GameObject.Find("Canvas").GetComponent<Score>().AddScore();
            Destroy(gameObject);
        }
    }

    public void Damege()
    {
        --hp;
    }
}
