using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube") ;
        {
            Destroy(collision.gameObject);
        }
    }
    void OnGUI()
    {
        if (GUILayout.Button("Restart"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

}
