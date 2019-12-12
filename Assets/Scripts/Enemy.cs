using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{

    private NavMeshAgent Foe;

    public static GameObject Player;

    public float EnemyDistance = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        Foe = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        float rayDistance;
        Vector3 rayForward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, rayForward, Color.green);

        //Recognize Player(s):
        if(Physics.Raycast(transform.position,(rayForward), out hit))
        {
            if(hit.collider.gameObject.name == "EthanPrefab(Clone)")
            {
                Player = hit.collider.gameObject;
                //Waypoints.chaseMode = true;
            }
        }

        float distance = Vector3.Distance(transform.position, Player.transform.position);

        // Follow player

        if(distance <= EnemyDistance)
        {
            Waypoints.chaseMode = true;

            //transform.LookAt(Player.transform.position);

            Vector3 directToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - directToPlayer;

            Foe.SetDestination(newPos);
        }
        else if(distance > EnemyDistance)
        {
            Waypoints.chaseMode = false;
            Waypoints.speedCheck = true;
            //Vector3 newPos = transform.position - Waypoints.waypoints[Waypoints.current].transform.position;
            //Foe.SetDestination(newPos);
            transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
        }

        //Damage Player:
        void OnCollisionEnter(Collision collision)
        {
            var strike = collision.gameObject;
            var health = strike.GetComponent<Health>();
            if(health != null)
            {
                health.TakeDamage(10);
            }
        }

        if(ScoreSystem.winCheck == true)
        {
            Destroy(this.gameObject);
        }
    }
}
