using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerHore : MonoBehaviour
{
    [SerializeField] private Animator anim;

    public GameObject popUpButton;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            popUpButton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            popUpButton.SetActive(false);
        }
    }
}
