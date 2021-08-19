using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDoor : MonoBehaviour
{
    [SerializeField] private Door _door;
    private bool _isChecked;
    private void Start() {
      StartCoroutine(DestroyDoor());
    }
    private IEnumerator DestroyDoor()
    {
        yield return new WaitForSeconds(1f);
         if (!_isChecked)
        {
            Destroy(_door.gameObject);
        }

    }
private void OnTriggerEnter2D(Collider2D other) 
{
    if (other.TryGetComponent<Room>(out Room room))
    {
      int active = (int)_door.TypeOfDoor;
      room.Doors[active].gameObject.SetActive(true);
      _isChecked = true;
    }
}
}
