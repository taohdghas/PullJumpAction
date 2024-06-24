using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSource;
    public Stage1ManagerScript Stage1Manager;
    public Stage2ManagerScript Stage2Manager;
    public Stage3ManagerScript Stage3Manager;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = gameObject.GetComponent<AudioSource>();
        if (Stage1Manager == null)
        {
            Stage1Manager = FindObjectOfType<Stage1ManagerScript>();
        }
        if(Stage2Manager == null)
        {
            Stage2Manager = FindObjectOfType<Stage2ManagerScript>();
        }
        if (Stage3Manager == null)
        {
            Stage3Manager = FindObjectOfType<Stage3ManagerScript>();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        // DestroySelf();
        animator.SetTrigger("Get");
        audioSource.Play();
        if(Stage1Manager != null)
        {
            Stage1Manager.SetCleard();
        }
        if(Stage2Manager != null)
        {
            Stage2Manager.SetCleard();
        }
        if (Stage3Manager != null)
        {
            Stage3Manager.SetCleard();
        }
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit");
    }
    
    private void DestroySelf()
    {
        Destroy(gameObject);
    }

}
