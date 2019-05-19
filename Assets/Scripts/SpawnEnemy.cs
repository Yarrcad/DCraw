using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        //int rand = Random.Range(0, objects.Length);
        if (Random.value < (float)GlobalVarbs.level * .01)
        {
            GameObject instance = (GameObject)Instantiate(objects[0], transform.position, Quaternion.identity);
            instance.transform.parent = transform;
        }
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemoi");
        foreach (GameObject target in enemies)
        {
            float distance = Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, target.transform.position);
            if (distance <= 5)
            {
                Destroy(target);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
