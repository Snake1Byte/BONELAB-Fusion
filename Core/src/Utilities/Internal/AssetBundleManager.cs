﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

using LabFusion.Data;

namespace LabFusion.Utilities
{
    internal static class AssetBundleManager {
        internal static AssetBundle PlayerRepBundle { get; private set; }

        internal static void OnLoadBundles() {
            PlayerRepBundle = EmebeddedAssetBundle.LoadFromAssembly(FusionMod.FusionAssembly, ResourcePaths.PlayerRepPath);

            if (PlayerRepBundle == null)
                throw new NullReferenceException("PlayerRepBundle is null! Did you forget to compile rep.atom into the dll?");
        }
    }
}