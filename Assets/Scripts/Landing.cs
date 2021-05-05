using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Landing : MonoBehaviour
{
    public GameObject moon;
    public AudioSource radioChatter;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.LookAt(moon.transform);
        radioChatter.Play();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == moon)
        {
            SceneManager.LoadScene(sceneName: "Moon");
        }
     
    }
}
