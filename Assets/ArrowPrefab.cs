using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ArrowPrefab : MonoBehaviour
{
    int TARGET_DISTANCE = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start of logging...");
    }

    bool hitTarget = false;

    Vector3 finalPos;
    Vector3 finalAngle;

    // Update is called once per frame
    void Update()
    {
        if (!hitTarget)
        {
            if (transform.position.z > TARGET_DISTANCE - 2 &
                transform.position.x > -5 & transform.position.x < 5 &
                transform.position.y > -5 & transform.position.y < 5)
            {
                Debug.Log("Hit the target");
                hitTarget = true;
                finalPos = transform.position;
                finalAngle = transform.eulerAngles;

                int dist = (int) Mathf.Floor(Mathf.Sqrt(Mathf.Pow(2 * finalPos.x, 2) + Mathf.Pow(2 * finalPos.y, 2)));
                if (dist < 10) {
                    Debug.Log("Scored " + (10 - dist) + " points");
                    Scoreboard.score += (10 - dist);
                }
            }
        }
        else
        {
            transform.position = finalPos;
            transform.eulerAngles = finalAngle;
        }
    }
}
