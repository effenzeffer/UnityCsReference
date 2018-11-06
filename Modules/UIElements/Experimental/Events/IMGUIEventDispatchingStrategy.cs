// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

namespace UnityEngine.Experimental.UIElements
{
    class IMGUIEventDispatchingStrategy : IEventDispatchingStrategy
    {
        public bool CanDispatchEvent(EventBase evt)
        {
            return evt is IMGUIEvent;
        }

        public void DispatchEvent(EventBase evt, IPanel panel)
        {
            if (panel != null)
            {
                EventDispatchUtilities.PropagateToIMGUIContainer(panel.visualTree, evt);
            }

            evt.propagateToIMGUI = false;
            evt.stopDispatch = true;
        }
    }
}
