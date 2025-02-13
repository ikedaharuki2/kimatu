    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class EnmyBullet : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
                
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(-0.05f,0,0);
            if (transform.position.x < -12)
            Destroy(gameObject);
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.gameObject.tag == "Player")
            {
                other.GetComponent<Player>().Damege();
                Destroy(gameObject);       
            }
        }
    }
