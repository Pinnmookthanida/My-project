using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brownhorses : MonoBehaviour
{
     public AudioClip horses;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
        Debug.Log("screaming");
        GetComponent<AudioSource>().PlayOneShot(horses);


    }
}
