using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peopletalking : MonoBehaviour
{
    public AudioClip people;
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
       ShowUI();


    }

    public void agree()
    {
        Debug.Log("talking");
        GetComponent<AudioSource>().PlayOneShot(people);
    }
    public void HideUI()
    {
     ui.SetActive(false);
     Cursor.lockState = CursorLockMode.Locked;
     Cursor.visible = false;
    }
    public void ShowUI()
    {
        ui.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void PressAgree(){
        HideUI();
        
    }
}
