using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : MonoBehaviour
{
    public AudioClip deer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Running");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Moose");
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(deer);
        }
    }
}
