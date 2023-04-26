using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteakController : MonoBehaviour
{
    public int win = 7;

    void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if(playerInventory != null)
        {
            playerInventory.SteakCollected();
            gameObject.SetActive(false);
        }if(playerInventory.steakNumber == 20)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}
