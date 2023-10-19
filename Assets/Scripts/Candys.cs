using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candys : MonoBehaviour
{
    Collectables Candy;

    public void Awake()
    {
       Candy = new Collectables("Candy", 1, 0);
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            Candy.UpdateScore();
            Destroy(gameObject);

        }
    }
}
