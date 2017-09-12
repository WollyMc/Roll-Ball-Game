using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{

    void OnGUI()
    {
        if (GUILayout.Button("Restart"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
