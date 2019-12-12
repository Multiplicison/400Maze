using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static GameObject[] waypoints;
    public static int current = 0;
    //float rotSpeed;
    public float speed = 4;
    float WPradius = 2;
    public static bool chaseMode = false;
    public static bool speedCheck = false;

    // Update is called once per frame
    void Update()
    {
        if (chaseMode == false)
        {
            if (speedCheck == true)
            {
                speed = 0;
                speedCheck = false;
                speed = 4;
            }

            if (speedCheck == false)
            {
                if (Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
                {
                    current++;
                    if (current >= waypoints.Length)
                    {
                        current = 0;
                    }
                }
                transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);
            }
        }
        else if (chaseMode == true)
        {
            //Write MoveTowards function to replace Enemy.cs.  The two are conflicting.
        }
    }
}
