using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
   public static T Instance { get; private set; }
   protected virtual void Awake()
    {
        Debug.Log("Da vao");
        Instance = this as T;
    }
}
