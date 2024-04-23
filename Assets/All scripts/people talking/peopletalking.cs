using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peopletalking : MonoBehaviour
{
    public AudioClip people;
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
        
        Debug.Log("talking");
        GetComponent<AudioSource>().PlayOneShot(people);


    }
}
