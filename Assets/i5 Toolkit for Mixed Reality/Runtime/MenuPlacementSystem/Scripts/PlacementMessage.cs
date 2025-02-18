﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace i5.Toolkit.MixedReality.MenuPlacementSystem {
    public class PlacementMessage {
        public enum SwitchType {
            CompactToFloating,
            FloatingToCompact,
            NoSwitch
        };

        public SwitchType switchType;

        public PlacementMessage() {
            switchType = SwitchType.NoSwitch;
        }

        public PlacementMessage(SwitchType type) {
            switchType = type;
        }

    }
}

