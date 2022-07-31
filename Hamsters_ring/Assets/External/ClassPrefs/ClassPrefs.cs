using System;
using System.IO;
using UnityEngine;

public static class ClassPrefs
{
    private static readonly string PATH = Path.Combine(Application.persistentDataPath);
    private static bool DebugEnabled = false;
    
    public static void SetClass<T>(string key, T data) where T : class
    {
        string jsonData = JsonUtility.ToJson(data);
        string dataPath = Path.Combine(PATH, key);
        try
        {
            File.WriteAllText(dataPath, jsonData);
            if (DebugEnabled)
                Debug.Log("File saved :" + dataPath);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
    public static void SetClassByPath<T>(string path, T data) where T : class
    {
        string jsonData = JsonUtility.ToJson(data);
        try
        {
            File.WriteAllText(path, jsonData);
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }
    public static T GetClassByPath<T>(string path) where T : class
    {
        try
        {
            if (HasData(path))
            {
                string jsonData = File.ReadAllText(path);
                T loadedData = JsonUtility.FromJson<T>(jsonData);
                return loadedData;
            }
            else
            {
                if (DebugEnabled)
                    Debug.Log("File don't exist");
                return null;
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return null;
        }
    }
    public static T GetClassByKey<T>(string key, bool showPath = false) where T : class
    {
        string dataPath = Path.Combine(PATH, key);
        try
        {
            if (HasKey(key))
            {
                string jsonData = File.ReadAllText(dataPath);
                T loadedData = JsonUtility.FromJson<T>(jsonData);
                if (showPath)
                    Debug.Log(dataPath);
                return loadedData;
            }
            else
            {
                Debug.Log("File don't exist in " + dataPath);
                return null;
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
            return null;
        }
    }
    public static bool HasKey(string key)
    {
        var path = Path.Combine(PATH, key);
        //Debug.Log(path);
        return File.Exists(path);
    }
    public static bool HasData(string path)
    {
        return File.Exists(path);
    }
}
