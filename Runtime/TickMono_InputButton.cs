using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class TickMono_InputButton: MonoBehaviour
{
    public InputActionReference m_inputAction;
    public UnityEvent m_onChanged;
    public UnityEvent m_onDown;
    public UnityEvent m_onUp;

    public bool m_isPressed;
    void OnEnable()
    {
        m_inputAction.action.Enable();
        m_inputAction.action.performed += ctx => Context(ctx);
        m_inputAction.action.started += ctx => Context(ctx);
        m_inputAction.action.canceled += ctx => Context(ctx);
    }
    private void OnDisable()
    {
        m_inputAction.action.Disable();
        m_inputAction.action.performed -= ctx => Context(ctx);
        m_inputAction.action.started -= ctx => Context(ctx);
        m_inputAction.action.canceled -= ctx => Context(ctx);
    
    }


    void Context(InputAction.CallbackContext ctx)
    {
        bool isPressed = ctx.ReadValue<float>() > 0.5f;
        if (isPressed != m_isPressed)
        {
            m_isPressed = isPressed;
            m_onChanged.Invoke();
            if (m_isPressed)
            {
                m_onDown.Invoke();
            }
            else
            {
                m_onUp.Invoke();
            }
        }
    }
}


