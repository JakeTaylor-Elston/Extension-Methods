using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerPrefExtensions
{
    public static string InitializeString(string key, string defaultValue)
    {
        if(PlayerPrefs.HasKey(key))
        {
            return PlayerPrefs.GetString(key);
        }

        else
        {
            PlayerPrefs.SetString(key, defaultValue);
            return defaultValue;
        }
    }

    public static int InitializeInt(string key, int defaultValue)
    {
        if(PlayerPrefs.HasKey(key))
        {
            return PlayerPrefs.GetInt(key);
        }

        else
        {
            PlayerPrefs.SetInt(key, defaultValue);
            return defaultValue;
        }
    }

    public static float InitializeFloat(string key, float defaultValue)
    {
        if(PlayerPrefs.HasKey(key))
        {
            return PlayerPrefs.GetFloat(key);
        }

        else
        {
            PlayerPrefs.SetFloat(key, defaultValue);
            return defaultValue;
        }
    }
}