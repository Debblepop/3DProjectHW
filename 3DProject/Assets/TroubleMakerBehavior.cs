using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TroubleMakerBehavior : MonoBehaviour
{
    public GameObject GameManager;
    public float TroubleMakerDMG = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TroubleMakerDMG > 0)
        {
            TroubleMakerDMG -= Time.deltaTime;
        }
        if (TroubleMakerDMG <= 0)
        {
            GameManager.GetComponent<GameManagerScript>().StoreHealth -= 10;
            TroubleMakerDMG = 10;
        }

       

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.GetComponent<GameManagerScript>().StoreHealth += 35;
        }
    }
}
