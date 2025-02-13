using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnmy : MonoBehaviour
{
    public GameObject EnmyBullet;
    int hp = 5;
    float x = 0;
    bool y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 4)
            y = true;
        
        if(transform.position.y < -4)
            y = false;

        if (transform.position.x > 7)
            transform.Translate(-0.01f, 0, 0);

        if (!y)
        {
            transform.Translate(0, 0.01f, 0);
        }

        if (y)
        {
            transform.Translate(0, -0.01f, 0);
        }

        x += 0.002f;

        if(x >= 1)
        {
            Instantiate(EnmyBullet, transform.position, Quaternion.identity);
            x = 0;
        }

        if (hp <= 0)
        {
            GameObject.Find("Canvas").GetComponent<Score>().AddScore();
            GameObject.Find("Canvas").GetComponent<Score>().AddScore();
            Destroy(gameObject);
        }
    }

    public void Damege()
    {
        --hp;
    }
}
