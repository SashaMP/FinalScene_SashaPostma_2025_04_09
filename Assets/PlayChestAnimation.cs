using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayChestAnimation : MonoBehaviour
{
    [SerializeField] private Animator chestController;
    [SerializeField] private Animator kaerrController;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("help");

        if (other.CompareTag("Player"))
        {
            chestController.SetBool("PlayChestAnim", true);
            kaerrController.SetBool("PlayIdleAnim", true);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            chestController.SetBool("PlayChestAnim", false);
            kaerrController.SetBool("PlayIdleAnim", false);
        }

    }
}
