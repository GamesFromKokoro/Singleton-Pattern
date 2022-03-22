using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    /* Singleton is used as an generic <T> abstract class thats inherits from MonoBehaviour from the "T" generics
     * has a single static variable instance with only a Get propertier.
     * Uses the Unity Awake() method to get started before from the other main Unity methods
     * Has a Protected and virtual to get override and to be used from inherits classes
     * This method consists totest if the game object are null, that way apply the instance in the game object
     * If there is already one (or more than one), it get destroied. */

    //Just inherit from the singleton class by putting the generic type into the class itself.

    //Generic variable for static use
    private static T instance;

    //Constructor to get this instance
    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            //The singleton class will already deal with inheriting the monoBehavior in addition
            //to manipulating the gameObject itself in the scene through the variable "This"
            instance = this as T;
        }
        else
        {
            //Destroy another instances of the object in the scene
            Destroy(gameObject);
        }
    }
}