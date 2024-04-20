using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class littlechicken : MonoBehaviour
{
        
    public AudioClip chicken;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("chickennoise");
        GetComponent<AudioSource>().PlayOneShot(chicken);
    }

}