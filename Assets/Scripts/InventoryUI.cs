using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI steakText;

    void Start()
    {
        steakText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateSteakText(PlayerInventory playerInventory)
    {
        steakText.text = playerInventory.steakNumber.ToString();
    }
}
