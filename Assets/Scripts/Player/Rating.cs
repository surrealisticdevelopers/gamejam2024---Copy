using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rating : MonoBehaviour
{
    [SerializeField] private float maxRating = 100.0f;
    [SerializeField] private float currentRating;

    void Start()
    {
        currentRating = maxRating;
    }

    public void AddHealth(float value)
    {
        currentRating += value;
    }    
    public void RemoveHealth(float value)
    {
        currentRating -= value;
    }

    public float GetMaxHealth()
    {
        return maxRating;
    }
    public float GetCurrentHealth()
    {
        return currentRating;
    }

    public bool IsPlayerDead()
    {
        return currentRating <= 0.0f;
    }

}
