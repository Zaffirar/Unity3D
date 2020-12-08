using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrel : MonoBehaviour
{
    public GameObject deathEffect;
    static public int noBarrels=0;
    // Start is called before the first frame update
    void Start()
    {
        noBarrels++;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-40f)
        {
            
            noBarrels--;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            if(noBarrels<=0)
            {
                noBarrels=0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            
        }
    }
}
