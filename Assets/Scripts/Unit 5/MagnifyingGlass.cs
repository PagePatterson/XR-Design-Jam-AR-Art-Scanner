using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnifyingGlass : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    // Update is called once per frame
    void Update()
    {
        Vector3 middleOfScreen = _camera.ViewportToWorldPoint(new Vector2 (0.5f, 0.5f));
        Vector3 middleOfMagnifyingGlass = this.transform.position;
        Vector3 directionToGlass = (middleOfMagnifyingGlass - middleOfScreen).normalized;

        if (!Physics.Raycast(transform.position,directionToGlass,out RaycastHit hit))
        {
            return;
        }
        Organ organ = hit.collider.GetComponent<Organ>();
        if (organ == null) {
            return;
        }
        organ.FoundImage();
    }
}
