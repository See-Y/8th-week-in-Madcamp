//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Convai/Resources/Controls.inputactions
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

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""9966ac18-db5e-4728-b610-7a4351d57f83"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""37317921-e05d-49eb-80ba-4037dc3422e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Talk"",
                    ""type"": ""Button"",
                    ""id"": ""7efd48a1-36f9-41dc-ba05-64f4e37985a2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b5c6fdbe-4e72-4cb2-9ddf-0afea5878846"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""d4bfac40-fd90-46ab-a1f6-07c2a12d8a93"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MousePress"",
                    ""type"": ""Button"",
                    ""id"": ""a4a2b620-6da1-47db-9898-5d5d9be49c3f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""33720f42-6005-4ea1-b461-e518f7f56d7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SendText"",
                    ""type"": ""Button"",
                    ""id"": ""8b3cda63-fdb6-4e88-8ab7-83b28b309345"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleChat"",
                    ""type"": ""Button"",
                    ""id"": ""35745f7d-43f1-4748-863e-5b3717499377"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ToggleSettings"",
                    ""type"": ""Button"",
                    ""id"": ""2feff8e6-737d-4f11-892e-60a1eedbe5b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CursorUnlock"",
                    ""type"": ""Button"",
                    ""id"": ""b140b6bf-eff7-4213-a43d-47c7c4f9f492"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5e200eed-fa09-4181-a9e5-aa009d612ed4"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb6fde4e-4025-40db-9dec-67816470992d"",
                    ""path"": ""<XRController>{RightHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Talk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eca909b4-db20-4f74-86ec-48d30a34f031"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84dfc447-9a58-4847-a95b-9a627aaea2be"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c127d1e2-7779-466e-b581-da40ce30c20d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7c35996-adf9-4d25-94b7-79da3fec3cb3"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""623c4a89-84cc-49c3-8f71-ca7279eb8aff"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""MousePress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b507475-97b7-4abf-9260-f4dbf660f3e0"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""56d4eeb9-b44c-464a-9d22-ac9ea1222a5c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d15a19ee-6b22-44f1-b395-64398c46546a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SendText"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6e7b391-e488-4f74-8a7d-5d5b796974f6"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""SendText"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33c7b6d1-867b-4aca-9060-b8aea01e3721"",
                    ""path"": ""<Keyboard>/f10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ToggleSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3c15933-b52e-4001-933b-94a6dcfdd101"",
                    ""path"": ""<XRController>{LeftHand}/primaryButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleSettings"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3416803c-a95a-41df-a64d-ae6cc8c2e64b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""CursorUnlock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7e3e583b-4e18-4003-b380-978c8a4bbf0c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6adb1637-1bc6-44d2-b3fd-5c93d017a219"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ab89f620-d2e2-46b0-9660-85ffd40b5cf5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0cd0d468-98bc-4b60-93ae-ab6579ab2d2a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""52a6ec8e-eea9-4d91-876a-ff7f5e3f2b38"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2ba6d4cc-6dec-4b63-8308-e3c6f91021b5"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d927d629-af22-41c8-9b0a-3b8e304f3b54"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ToggleChat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5262ea16-6f64-4b42-8383-ba8d54cbf2c5"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard & Mouse"",
                    ""action"": ""ToggleChat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard & Mouse"",
            ""bindingGroup"": ""Keyboard & Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mobile"",
            ""bindingGroup"": ""Mobile"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Talk = m_Player.FindAction("Talk", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_MousePress = m_Player.FindAction("MousePress", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_SendText = m_Player.FindAction("SendText", throwIfNotFound: true);
        m_Player_ToggleChat = m_Player.FindAction("ToggleChat", throwIfNotFound: true);
        m_Player_ToggleSettings = m_Player.FindAction("ToggleSettings", throwIfNotFound: true);
        m_Player_CursorUnlock = m_Player.FindAction("CursorUnlock", throwIfNotFound: true);
    }

    ~@Controls()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, Controls.Player.Disable() has not been called.");
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
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Talk;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_MousePress;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_SendText;
    private readonly InputAction m_Player_ToggleChat;
    private readonly InputAction m_Player_ToggleSettings;
    private readonly InputAction m_Player_CursorUnlock;
    public struct PlayerActions
    {
        private @Controls m_Wrapper;
        public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Talk => m_Wrapper.m_Player_Talk;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @MousePress => m_Wrapper.m_Player_MousePress;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @SendText => m_Wrapper.m_Player_SendText;
        public InputAction @ToggleChat => m_Wrapper.m_Player_ToggleChat;
        public InputAction @ToggleSettings => m_Wrapper.m_Player_ToggleSettings;
        public InputAction @CursorUnlock => m_Wrapper.m_Player_CursorUnlock;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Talk.started += instance.OnTalk;
            @Talk.performed += instance.OnTalk;
            @Talk.canceled += instance.OnTalk;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @MousePress.started += instance.OnMousePress;
            @MousePress.performed += instance.OnMousePress;
            @MousePress.canceled += instance.OnMousePress;
            @Run.started += instance.OnRun;
            @Run.performed += instance.OnRun;
            @Run.canceled += instance.OnRun;
            @SendText.started += instance.OnSendText;
            @SendText.performed += instance.OnSendText;
            @SendText.canceled += instance.OnSendText;
            @ToggleChat.started += instance.OnToggleChat;
            @ToggleChat.performed += instance.OnToggleChat;
            @ToggleChat.canceled += instance.OnToggleChat;
            @ToggleSettings.started += instance.OnToggleSettings;
            @ToggleSettings.performed += instance.OnToggleSettings;
            @ToggleSettings.canceled += instance.OnToggleSettings;
            @CursorUnlock.started += instance.OnCursorUnlock;
            @CursorUnlock.performed += instance.OnCursorUnlock;
            @CursorUnlock.canceled += instance.OnCursorUnlock;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Talk.started -= instance.OnTalk;
            @Talk.performed -= instance.OnTalk;
            @Talk.canceled -= instance.OnTalk;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @MousePress.started -= instance.OnMousePress;
            @MousePress.performed -= instance.OnMousePress;
            @MousePress.canceled -= instance.OnMousePress;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @SendText.started -= instance.OnSendText;
            @SendText.performed -= instance.OnSendText;
            @SendText.canceled -= instance.OnSendText;
            @ToggleChat.started -= instance.OnToggleChat;
            @ToggleChat.performed -= instance.OnToggleChat;
            @ToggleChat.canceled -= instance.OnToggleChat;
            @ToggleSettings.started -= instance.OnToggleSettings;
            @ToggleSettings.performed -= instance.OnToggleSettings;
            @ToggleSettings.canceled -= instance.OnToggleSettings;
            @CursorUnlock.started -= instance.OnCursorUnlock;
            @CursorUnlock.performed -= instance.OnCursorUnlock;
            @CursorUnlock.canceled -= instance.OnCursorUnlock;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard & Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_MobileSchemeIndex = -1;
    public InputControlScheme MobileScheme
    {
        get
        {
            if (m_MobileSchemeIndex == -1) m_MobileSchemeIndex = asset.FindControlSchemeIndex("Mobile");
            return asset.controlSchemes[m_MobileSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnTalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnMousePress(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnSendText(InputAction.CallbackContext context);
        void OnToggleChat(InputAction.CallbackContext context);
        void OnToggleSettings(InputAction.CallbackContext context);
        void OnCursorUnlock(InputAction.CallbackContext context);
    }
}
