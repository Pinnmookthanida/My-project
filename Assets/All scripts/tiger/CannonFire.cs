using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    
    public AudioClip tiger;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("crying");
        GetComponent<AudioSource>().PlayOneShot(tiger);
    }

}
