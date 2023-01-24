using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBehavior : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private LayerMask _mousePlaneLayerMask;
    private static MouseBehavior _instance;

    #endregion Fields

    #region Methods

    /// <summary>
    /// Initializes once, before the applicatiion starts.
    /// </summary>
    private void Awake()
    {
        _instance = this;
    }

    /// <summary>
    /// Returns the raycast point of the mouse, which is anchored to the player's main camera.
    /// </summary>
    /// <returns></returns>
    public static Vector3 GetPosition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Note: Needs Main Camera tag.
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, _instance._mousePlaneLayerMask);
        return raycastHit.point;
    }

    #endregion Methods
}
