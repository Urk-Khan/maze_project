using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levels_script : MonoBehaviour
{
    [SerializeField]
    string tagName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == tagName)
        {
            SceneManager.LoadScene("Level_2");
        }
    }
}
