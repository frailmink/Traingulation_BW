//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/createPoint.inputactions
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

public partial class @CreatePoint : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CreatePoint()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""createPoint"",
    ""maps"": [
        {
            ""name"": ""point"",
            ""id"": ""27fb1ff8-0859-4f1e-81ce-702136504583"",
            ""actions"": [
                {
                    ""name"": ""add"",
                    ""type"": ""Button"",
                    ""id"": ""22430d42-9402-4eb1-b9e1-8834389bcfa4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4ac1385a-d45e-4cf7-b432-70e816e6d160"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""add"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // point
        m_point = asset.FindActionMap("point", throwIfNotFound: true);
        m_point_add = m_point.FindAction("add", throwIfNotFound: true);
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

    // point
    private readonly InputActionMap m_point;
    private IPointActions m_PointActionsCallbackInterface;
    private readonly InputAction m_point_add;
    public struct PointActions
    {
        private @CreatePoint m_Wrapper;
        public PointActions(@CreatePoint wrapper) { m_Wrapper = wrapper; }
        public InputAction @add => m_Wrapper.m_point_add;
        public InputActionMap Get() { return m_Wrapper.m_point; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PointActions set) { return set.Get(); }
        public void SetCallbacks(IPointActions instance)
        {
            if (m_Wrapper.m_PointActionsCallbackInterface != null)
            {
                @add.started -= m_Wrapper.m_PointActionsCallbackInterface.OnAdd;
                @add.performed -= m_Wrapper.m_PointActionsCallbackInterface.OnAdd;
                @add.canceled -= m_Wrapper.m_PointActionsCallbackInterface.OnAdd;
            }
            m_Wrapper.m_PointActionsCallbackInterface = instance;
            if (instance != null)
            {
                @add.started += instance.OnAdd;
                @add.performed += instance.OnAdd;
                @add.canceled += instance.OnAdd;
            }
        }
    }
    public PointActions @point => new PointActions(this);
    public interface IPointActions
    {
        void OnAdd(InputAction.CallbackContext context);
    }
}
