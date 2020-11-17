using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class hurB : MonoBehaviour
{
    void Start()
    { }
    private bool OnWater;
     
    private void OnTriggerEnter(Collider collision)
    {
        OnWater = false;
        if (collision.gameObject.tag == "Water")
        {
            OnWater = true;
            
       }
        if(OnWater == true)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
