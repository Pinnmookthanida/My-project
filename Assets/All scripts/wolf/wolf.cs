using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class wolfie : MonoBehaviour
{
    public AudioClip wolf;
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
        
        Debug.Log("howling");
        GetComponent<AudioSource>().PlayOneShot(wolf);

        SceneManager.LoadScene("burnt scene", LoadSceneMode.Single);
    }
}
