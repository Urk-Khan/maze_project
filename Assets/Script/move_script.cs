using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_script : MonoBehaviour
{
    [SerializeField]
    Vector3 frcForward;
    [SerializeField]
    Vector3 frcBackword;
    [SerializeField]
    Vector3 frcLeft;
    [SerializeField]
    Vector3 frcRight;
    [SerializeField]
    Vector3 frcUp;
    [SerializeField]
    Vector3 rotateRight;
    [SerializeField]
    Vector3 RotateLeft;

    [SerializeField]
    KeyCode keyForward;
    [SerializeField]
    KeyCode keyBacword;
    [SerializeField]
    KeyCode keyLeft;
    [SerializeField]
    KeyCode keyRight;
    [SerializeField]
    KeyCode keyUp;

    [SerializeField]
    KeyCode keyRotateRight;
    [SerializeField]
    KeyCode keyRotateLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(keyForward))
        {
            GetComponent<Rigidbody>().velocity += frcForward;
        }
        if(Input.GetKey(keyBacword))
        {
            GetComponent<Rigidbody>().velocity -= frcBackword;
        }
        if(Input.GetKey(keyLeft))
        {
            GetComponent<Rigidbody>().velocity -= frcLeft;
        }
        if(Input.GetKey(keyRight))
        {
            GetComponent<Rigidbody>().velocity += frcRight;
        }
        if(Input.GetKey(keyUp))
        {
            GetComponent<Rigidbody>().velocity += frcUp;
        }

        if(Input.GetKey(keyRotateRight))
        {
            transform.Rotate(rotateRight * Time.deltaTime);
        }
        if(Input.GetKey(keyRotateLeft))
        {
            transform.Rotate(RotateLeft * Time.deltaTime);
        }
    }
}
