//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Settings/TankControls.inputactions
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

namespace Tanks
{
    public partial class @TankControls: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @TankControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""TankControls"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""349c2f62-a9c2-48e2-8acb-11bf5e1b8e4b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""b3c22a0d-b8dd-4d12-8ee4-01be2644ccd5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Handbreak"",
                    ""type"": ""Button"",
                    ""id"": ""30a59430-58c0-49b9-8b7b-574a18a5bf68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""02e58a0c-4487-4e10-a8e5-0de5ce986602"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5b031351-e3ec-4d14-91e0-992d71b7a7f7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7b261aaf-2695-4fd7-8973-296fbcef3351"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""346c26a4-6349-41b6-8e5e-187bbe77ceef"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""79b8d7b9-ed52-4c6a-9708-09e3f833e118"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""31d67a2a-7f1e-42ab-8871-5a66591780d2"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Handbreak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Turret"",
            ""id"": ""ee408226-575a-45c5-9b8a-32b89218dedb"",
            ""actions"": [
                {
                    ""name"": ""Focus"",
                    ""type"": ""Value"",
                    ""id"": ""490d227b-994b-41d9-a52a-5a0f31c6555d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""6e85f583-8e16-4c9c-8c80-4c9ed18d6933"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c975d314-9f22-401a-8962-2b3340d6e8fd"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Focus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2719a6d6-e644-41ba-a985-23767035e9ed"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Tank
            m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
            m_Tank_Movement = m_Tank.FindAction("Movement", throwIfNotFound: true);
            m_Tank_Handbreak = m_Tank.FindAction("Handbreak", throwIfNotFound: true);
            // Turret
            m_Turret = asset.FindActionMap("Turret", throwIfNotFound: true);
            m_Turret_Focus = m_Turret.FindAction("Focus", throwIfNotFound: true);
            m_Turret_Fire = m_Turret.FindAction("Fire", throwIfNotFound: true);
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

        // Tank
        private readonly InputActionMap m_Tank;
        private List<ITankActions> m_TankActionsCallbackInterfaces = new List<ITankActions>();
        private readonly InputAction m_Tank_Movement;
        private readonly InputAction m_Tank_Handbreak;
        public struct TankActions
        {
            private @TankControls m_Wrapper;
            public TankActions(@TankControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Tank_Movement;
            public InputAction @Handbreak => m_Wrapper.m_Tank_Handbreak;
            public InputActionMap Get() { return m_Wrapper.m_Tank; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
            public void AddCallbacks(ITankActions instance)
            {
                if (instance == null || m_Wrapper.m_TankActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TankActionsCallbackInterfaces.Add(instance);
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Handbreak.started += instance.OnHandbreak;
                @Handbreak.performed += instance.OnHandbreak;
                @Handbreak.canceled += instance.OnHandbreak;
            }

            private void UnregisterCallbacks(ITankActions instance)
            {
                @Movement.started -= instance.OnMovement;
                @Movement.performed -= instance.OnMovement;
                @Movement.canceled -= instance.OnMovement;
                @Handbreak.started -= instance.OnHandbreak;
                @Handbreak.performed -= instance.OnHandbreak;
                @Handbreak.canceled -= instance.OnHandbreak;
            }

            public void RemoveCallbacks(ITankActions instance)
            {
                if (m_Wrapper.m_TankActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITankActions instance)
            {
                foreach (var item in m_Wrapper.m_TankActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TankActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TankActions @Tank => new TankActions(this);

        // Turret
        private readonly InputActionMap m_Turret;
        private List<ITurretActions> m_TurretActionsCallbackInterfaces = new List<ITurretActions>();
        private readonly InputAction m_Turret_Focus;
        private readonly InputAction m_Turret_Fire;
        public struct TurretActions
        {
            private @TankControls m_Wrapper;
            public TurretActions(@TankControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Focus => m_Wrapper.m_Turret_Focus;
            public InputAction @Fire => m_Wrapper.m_Turret_Fire;
            public InputActionMap Get() { return m_Wrapper.m_Turret; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TurretActions set) { return set.Get(); }
            public void AddCallbacks(ITurretActions instance)
            {
                if (instance == null || m_Wrapper.m_TurretActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TurretActionsCallbackInterfaces.Add(instance);
                @Focus.started += instance.OnFocus;
                @Focus.performed += instance.OnFocus;
                @Focus.canceled += instance.OnFocus;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }

            private void UnregisterCallbacks(ITurretActions instance)
            {
                @Focus.started -= instance.OnFocus;
                @Focus.performed -= instance.OnFocus;
                @Focus.canceled -= instance.OnFocus;
                @Fire.started -= instance.OnFire;
                @Fire.performed -= instance.OnFire;
                @Fire.canceled -= instance.OnFire;
            }

            public void RemoveCallbacks(ITurretActions instance)
            {
                if (m_Wrapper.m_TurretActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITurretActions instance)
            {
                foreach (var item in m_Wrapper.m_TurretActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TurretActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TurretActions @Turret => new TurretActions(this);
        public interface ITankActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnHandbreak(InputAction.CallbackContext context);
        }
        public interface ITurretActions
        {
            void OnFocus(InputAction.CallbackContext context);
            void OnFire(InputAction.CallbackContext context);
        }
    }
}
