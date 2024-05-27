using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish: MonoBehaviour
{
    [SerializeField] private GameObject panewin;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            panewin.SetActive(true);
            Time.timeScale = 0;

        }
    }
}