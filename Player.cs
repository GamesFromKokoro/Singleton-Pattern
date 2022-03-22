using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>
{
    //Just inherit from the singleton class by putting the generic type into the class itself.
    //The singleton class will already deal with inheriting the monoBehavior in addition
    //to manipulating the gameObject itself in the scene through the variable "This"
}