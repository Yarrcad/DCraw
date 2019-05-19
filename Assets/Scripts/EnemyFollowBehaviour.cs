using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowBehaviour : MonoBehaviour
{
    public float speed;
 
    public float stopDistance;

    private Transform target;

    public Collider2D detectRange;



    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerStay2D(Collider2D detectRange)
    {
        // follow AI
        if (Vector2.Distance(transform.position, target.position) > stopDistance)
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }



}
