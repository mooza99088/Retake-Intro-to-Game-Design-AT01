using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class should be attached to the main camera.
/// </summary>
public class MouseLook : MonoBehaviour
{
    [Tooltip("The amount of influence mouse input has on camera movement. Must have a value above 0.")]
    [SerializeField] private float sensitivity = 2f;
    [Tooltip("The amount of 'drag' applied to the camera. Must have a value above 0.")]
    [SerializeField] private float drag;
    [Tooltip("The minimum and maximum angle that the camera can move on the y axis.")]
    [SerializeField] private Vector2 verticalClamp = new Vector2(-45, 70);

    private Vector2 mouseDir;
    private Vector2 smoothing;
    private Vector2 result;
    private Transform character;
   
    public bool LookEnabled { get; set; } = true;


    void Awake()
    {
        character = transform.parent;
        LookEnabled = true;
    }

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        if (LookEnabled == true)
        {
            mouseDir = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            mouseDir *= sensitivity;
            smoothing = Vector2.Lerp(smoothing, mouseDir, 1 / drag);
            result += smoothing;
            result.y = Mathf.Clamp(result.y, -70, 70);

            character.rotation = Quaternion.AngleAxis(result.x, character.up);
            transform.localRotation = Quaternion.AngleAxis(-result.y, Vector3.right);
        }
    }
}
