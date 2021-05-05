using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Launch : MonoBehaviour
{
    public AudioSource countDown;
    public AudioSource liftOff;
    public float liftSpeed;
    float countDownTime;
    //public float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        countDown.Play();
        countDownTime = 11f; 
    }

    // Update is called once per frame
    void Update()
    {
        if ((countDownTime - Time.timeSinceLevelLoad) > -1f && (countDownTime - Time.timeSinceLevelLoad) < 1f)
        {
            liftOff.Play();
            gameObject.GetComponent<ConstantForce>().force = Vector3.up * liftSpeed;
            //gameObject.GetComponent<ConstantForce>().relativeTorque = new Vector3(0, turnSpeed, 0);  
        }

        if (Time.timeSinceLevelLoad > 20f && Time.timeSinceLevelLoad < 21f)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(sceneName: "SpaceLaunch");
        }
    }
}
