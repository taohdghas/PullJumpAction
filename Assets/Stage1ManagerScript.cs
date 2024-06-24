using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1ManagerScript : MonoBehaviour
{
    public string nextSceneName;
    public GameObject clearText;

    private bool IsCleard = false;
    // Start is called before the first frame update
    void Start()
    {
        if (clearText != null)
        {
            clearText.SetActive(false);
        }
    }

    void Update()
    {
        if (IsCleard == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(nextSceneName);
            }
        }
    }

    public void SetCleard()
    {
        IsCleard = true;
        if (clearText != null)
        {
            clearText.SetActive(true);
        }
    }
}
