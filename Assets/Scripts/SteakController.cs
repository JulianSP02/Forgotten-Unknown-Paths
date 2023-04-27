using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteakController : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null)
        {
            playerInventory.SteakCollected();
            gameObject.SetActive(false);
        }if(playerInventory.steakNumber == 13)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
