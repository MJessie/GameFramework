﻿//----------------------------------------------
// Flip Web Apps: Game Framework
// Copyright © 2016 Flip Web Apps / Mark Hewitt
//
// Please direct any bugs/comments/suggestions to http://www.flipwebapps.com
// 
// The copyright owner grants to the end user a non-exclusive, worldwide, and perpetual license to this Asset
// to integrate only as incorporated and embedded components of electronic games and interactive media and 
// distribute such electronic game and interactive media. End user may modify Assets. End user may otherwise 
// not reproduce, distribute, sublicense, rent, lease or lend the Assets. It is emphasized that the end 
// user shall not be entitled to distribute or transfer in any way (including, without, limitation by way of 
// sublicense) the Assets in any other way than as integrated components of electronic games and interactive media. 

// The above copyright notice and this permission notice must not be removed from any files.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO
// THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//----------------------------------------------

using FlipWebApps.GameFramework.Scripts.Input.Components.AbstractClasses;
using UnityEngine;

namespace FlipWebApps.GameFramework.Scripts.UI.Dialogs.Components
{
    /// <summary>
    /// Loads the given level when a mouse button is pressed or the screen is tapped anywhere on the screen
    /// </summary>
    [AddComponentMenu("Game Framework/UI/Dialogs/OnMouseClickOrTapSwapDialogInstance")]
    [HelpURL("http://www.flipwebapps.com/unity-assets/game-framework/ui/dialogs/")]
    public class OnMouseClickOrTapSwapDialogInstance : OnMouseClickOrTap
    {
        /// <summary>
        /// Dialog instance that we want to swap from (the shown dislog instance)
        /// </summary>
        [Tooltip("Dialog instance that we want to swap from (the shown dislog instance)")]
        public DialogInstance Source;

        /// <summary>
        /// Dialog instance that we want to swap to
        /// </summary>
        [Tooltip("Dialog instance that we want to swap to")]
        public DialogInstance Target;

        /// <summary>
        /// Causes the dialog to swap as a result of a click or tap
        /// </summary>
        public override void RunMethod() {
            if (Source.IsShown)
            {
                Source.SwapTo(Target);
            }
        }
    }
}