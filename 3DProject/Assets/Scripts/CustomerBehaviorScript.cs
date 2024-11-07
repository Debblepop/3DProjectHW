using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerBehaviorScript : MonoBehaviour
{
    public GameObject GameManager;
    public float PassivePointTimer = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PassivePointTimer > 0)
        {
            PassivePointTimer -= Time.deltaTime;
        }
        else
        {
            GameManager.GetComponent<GameManagerScript>().StoreHealth += 20;
            PassivePointTimer = 30;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "TroubleMaker")
        {
            Destroy(gameObject);
        }
    }
}
