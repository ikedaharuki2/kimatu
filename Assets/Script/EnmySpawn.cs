using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmySpawn : MonoBehaviour
{
    public GameObject Enmy;
    public GameObject MoveEnmy;
    float x = 0;
    float y = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x += 0.01f; 
        y += 0.01f;

        if(x > 20)
        {
            int i = Random.Range(-4, 5);
            Instantiate(Enmy, new Vector2(12, i), Quaternion.identity);
            x = 0;
        }

        if (y > 60)
        {
            int i = Random.Range(-4, 5);
            Instantiate(MoveEnmy, new Vector2(12, i), Quaternion.identity);
            y = 0;
        }

    }
}
