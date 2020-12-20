using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genarate : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount;
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    // Update is called once per frame
  IEnumerator EnemyDrop()
    {
        while (enemyCount<=10)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.Range(1, 31);
            Instantiate(theEnemy, new Vector3(xPos, 43, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            int v = enemyCount +1;
        }
    }
}
