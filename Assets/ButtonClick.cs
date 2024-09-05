using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonClick : MonoBehaviour
{

    public ArrowPrefab arrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Touchscreen.current.press.isPressed)
        {
            ArrowPrefab arrow = Instantiate<ArrowPrefab>(arrowPrefab);
            arrow.transform.localPosition = transform.position;
            arrow.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward *
                UnityEngine.Random.Range(500, 750));
        }
    }
}
