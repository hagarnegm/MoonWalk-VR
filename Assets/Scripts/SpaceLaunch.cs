using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpaceLaunch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeSinceLevelLoad > 10f && Time.timeSinceLevelLoad < 11f)
        {
            SceneManager.LoadScene(sceneName: "Cockpit");
        }
    }
}
