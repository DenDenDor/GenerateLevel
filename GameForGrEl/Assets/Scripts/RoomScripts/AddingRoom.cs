using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingRoom : MonoBehaviour
{
  private List<Room> _rooms = new List<Room>();
  [SerializeField] private GameObject _boss;
  private void Start() {
      StartCoroutine(SpawnBoss());
  }
  public void AddRoom(Room room) => _rooms.Add(room);
  
  private IEnumerator SpawnBoss()
  {
      yield return new WaitForSeconds(6);
      Instantiate(_boss, _rooms[_rooms.Count - 1].transform.position, Quaternion.identity);
  }
}
