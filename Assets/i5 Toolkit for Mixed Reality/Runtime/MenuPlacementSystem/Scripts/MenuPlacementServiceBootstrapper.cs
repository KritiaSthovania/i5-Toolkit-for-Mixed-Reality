﻿using i5.Toolkit.Core.ServiceCore;
using UnityEngine;

namespace i5.Toolkit.MixedReality.MenuPlacementSystem {
    public class MenuPlacementServiceBootstrapper : BaseServiceBootstrapper {

        [SerializeField] private MenuPlacementService menuPlacementService;
        protected override void RegisterServices() {
            ServiceManager.RegisterService(menuPlacementService);
        }

        protected override void UnRegisterServices() {
            ServiceManager.RemoveService<MenuPlacementService>();
        }
    }
}
