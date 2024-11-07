using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public int StoreHealth = 1000;
    public GameObject TroublemakerPrefab;
    public GameObject CustomerPrefab;
    public float TroublespawnTimer = 5;
    public float CustomerspawnTimer = 15;
    public float GraceperiodTimer = 10;
    public bool GracePeriod = false;
    // Start is called before the first frame update
    void Start()
    {
        GracePeriod = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (GracePeriod)
        {
            if (GraceperiodTimer > 0)
            {
                GraceperiodTimer -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Grace Period is Done");
                GracePeriod = false;
            }
        }

        if (GracePeriod == false)
        {
            if (TroublespawnTimer > 0)
            {
                TroublespawnTimer -= Time.deltaTime;
                
            }
            else
            {
                Instantiate(TroublemakerPrefab);
                TroublespawnTimer = 5;
            }

            if (CustomerspawnTimer > 0)
            {
                CustomerspawnTimer -= Time.deltaTime;
            }
            else
            {
                Instantiate(CustomerPrefab);
                CustomerspawnTimer = 15; 
            }
        }
        Debug.Log("Store Health:  " + StoreHealth);
    }
}
