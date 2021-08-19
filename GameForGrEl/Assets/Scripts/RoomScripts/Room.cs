using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Room : MonoBehaviour
{
    [SerializeField] private Door[] _doors;
    public Door[] Doors { get => _doors; set => _doors = value; }
    private AddingRoom _addingRoom;
    private void Start() 
    {
        _addingRoom = FindObjectOfType<AddingRoom>();
        _addingRoom.AddRoom(this);
    }
}
