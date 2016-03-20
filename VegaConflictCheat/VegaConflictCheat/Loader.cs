using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace VegaConflictCheat
{
    public class Loader {
        public static GameObject Loaderobj;
        public static void Load() {
            if (Loaderobj == null) {
                Loaderobj = new GameObject();
                Loaderobj.AddComponent<Guiclass>();
                UnityEngine.Object.DontDestroyOnLoad(Loaderobj);
            }
        }
    }
}
