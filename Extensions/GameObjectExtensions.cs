using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
    public static void ToggleActiveState(this GameObject objectToToggle)
    {
        if(objectToToggle.activeInHierarchy)
        {
            objectToToggle.SetActive(false);
        }

        else
        {
            objectToToggle.SetActive(true);
        }
    }
}