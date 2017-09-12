using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour {

    void OnGUI()
    {
        if (GUILayout.Button("Next Level"))
        {
            Application.LoadLevel("LevelOne");
        }
    }
}
