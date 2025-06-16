using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int appleCount = 0;

    // Dodajemy metodę do zwiększania liczby jabłek
    public void AddApple()
    {
        appleCount++;
        Debug.Log("Dodano jabłko! Aktualna liczba: " + appleCount);
    }
}
