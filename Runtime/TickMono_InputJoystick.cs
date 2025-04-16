using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
namespace Eloi.Tick
{
    public class TickMono_InputJoystick : MonoBehaviour
    {
        public InputActionReference m_inputAction;
        public UnityEvent<Vector2> m_onValueChanged = new UnityEvent<Vector2>();
        public Vector2 m_joystickValue = new Vector2();

        void OnEnable()
        {
            m_inputAction.action.Enable();
            m_inputAction.action.performed += ctx => Context(ctx);
            m_inputAction.action.started += ctx => Context(ctx);
            m_inputAction.action.canceled += ctx => Context(ctx);
        }

        private void OnDisable()
        {
            //m_inputAction.action.Disable();
            m_inputAction.action.performed -= ctx => Context(ctx);
            m_inputAction.action.started -= ctx => Context(ctx);
            m_inputAction.action.canceled -= ctx => Context(ctx);
        }

        private void Context(InputAction.CallbackContext ctx)
        {
            m_joystickValue = ctx.ReadValue<Vector2>();
            m_onValueChanged?.Invoke(m_joystickValue);
        }
    }



}