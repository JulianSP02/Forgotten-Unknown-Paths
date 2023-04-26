using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int steakNumber;

    public UnityEvent<PlayerInventory> OnSteakCollected;

    public void SteakCollected()
    {
        steakNumber++;
        OnSteakCollected.Invoke(this);
    }
}
