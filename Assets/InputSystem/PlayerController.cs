//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerController.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerController : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""af1b190f-7ca5-4fa8-aad9-40cbe484b17a"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""816f7d8f-1e27-4e26-a304-2e0982d6eecd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangePart"",
                    ""type"": ""Button"",
                    ""id"": ""14cabc30-c860-4b59-99cd-50e37adb5853"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""c3cd9118-c350-4d91-aada-534bb5da322d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ExitPlayMode"",
                    ""type"": ""Button"",
                    ""id"": ""a1e9b1c6-2bd3-41ae-ad4a-a1f04d039c37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""27a5d04f-2a2a-4ff9-860b-257278144fd1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9a26339-ddf7-4c19-b712-7d9e0ecdaf73"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04a426de-3bc3-445f-8241-a7823d228036"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangePart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7483c726-a03b-4e1e-99e3-cdc384db6b88"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c71d12ad-7e5e-42a5-a66a-75976cf92f2a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitPlayMode"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_ChangePart = m_Player.FindAction("ChangePart", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_ExitPlayMode = m_Player.FindAction("ExitPlayMode", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_ChangePart;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_ExitPlayMode;
    public struct PlayerActions
    {
        private @PlayerController m_Wrapper;
        public PlayerActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @ChangePart => m_Wrapper.m_Player_ChangePart;
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @ExitPlayMode => m_Wrapper.m_Player_ExitPlayMode;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @ChangePart.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangePart;
                @ChangePart.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangePart;
                @ChangePart.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangePart;
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @ExitPlayMode.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExitPlayMode;
                @ExitPlayMode.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExitPlayMode;
                @ExitPlayMode.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnExitPlayMode;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @ChangePart.started += instance.OnChangePart;
                @ChangePart.performed += instance.OnChangePart;
                @ChangePart.canceled += instance.OnChangePart;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @ExitPlayMode.started += instance.OnExitPlayMode;
                @ExitPlayMode.performed += instance.OnExitPlayMode;
                @ExitPlayMode.canceled += instance.OnExitPlayMode;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnChangePart(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnExitPlayMode(InputAction.CallbackContext context);
    }
}
