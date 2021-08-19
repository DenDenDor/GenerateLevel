using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeOfDoor
{
    _top,
    _bottom,
    _right,
    _left
}
public class Door : MonoBehaviour
{
   [SerializeField] private TypeOfDoor _typeOfDoor;

    public TypeOfDoor TypeOfDoor { get => _typeOfDoor; set => _typeOfDoor = value; }
}
