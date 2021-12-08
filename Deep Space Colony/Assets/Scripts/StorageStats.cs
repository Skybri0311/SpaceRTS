using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StorageStats : MonoBehaviour
{
    public int health;
    public int storagMax;
    public int storageCurrent;

    public PawnStats pawnStats;

    private void Awake()
    {
        pawnStats = FindObjectOfType<PawnStats>();
    }

    public void AddStorage()
    {
        if (storageCurrent == storagMax)
        {
            Debug.Log("Storage Full");
            return;
        }
        else
        {
            storageCurrent += pawnStats.resourceCurrent;
            Debug.Log("Added Resources");
        }
            
    }
}
