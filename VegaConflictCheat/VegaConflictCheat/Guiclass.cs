using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace VegaConflictCheat {
    class Guiclass : MonoBehaviour {
        bool Menutog;
        void OnGUI() {
            if (Menutog) {
                GUI.Box(new Rect(100, 100, 100, 100), "The injection Worked");
            }
        }
        void Update() {
            if (UnityEngine.Input.GetKeyDown(KeyCode.J)) {
                Menutog = !Menutog;
            }
        }
    }
}

