using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandler : MonoBehaviour
{
    private Vector2 _inputDirection = new Vector2(0f, 0f);

    private void Awake() { }
    void Update()
    {
        GatherInputs();
    }
    private void FixedUpdate()
    {
        HandleInputs();
    }
    private void GatherInputs()
    {
        _inputDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Input.GetMouseButton(0))
        {
            if (EventSystem.current.IsPointerOverGameObject()) // checks whether the mouse is over a ui element,
            {
                return;
            }
        }
    }
    private void HandleInputs() { }
    private void ResetInputs() { }
}
