using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enemyspawn());
    }

    // Update is called onc=e per frame
    IEnumerator Enemyspawn()
    { 
     while(true)
        {
    
       
            Vector3 enemyspawn = new Vector3(Random.Range(-8f, 8f), 7f ,0);
            Instantiate(enemy, enemyspawn, Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}
