﻿/*************************************************************************
 * 
 *  Jelly Coroutines 
 *  By Ron Rejwan (Jan 2015) - ronr@jellybtn.com
 *  Jelly Button Games LTD. (http://www.jellybtn.com)
 *  -----------------------------------------------------------------
 *
 *  Feel free to use these coroutines in your project, please just leave
 *  these comments in the file and let me know if I helped you out.
 *  
 *  Also make sure to commit any fixes/improvement to our repository:
 *  https://github.com/rejwan/Jelly-Coroutines
 * 
 *************************************************************************/

using System.Collections;
using UnityEngine;

namespace JellyTools.Coroutines.Yields.ConcereteYields
{
    /// <summary>
    /// Yields until given animation has finished playing, sampling <see cref="Animation.isPlaying"/>
    /// </summary>
    public class WaitForAnimationStopPlaying : JBYieldInstruction
    {
        private readonly Animation _animation;

        public WaitForAnimationStopPlaying(Animation animation)
        {
            _animation = animation;

            Coroutine = CheckAnimationPlaying();
        }

        private IEnumerator CheckAnimationPlaying()
        {
            while (_animation.isPlaying)
            {
                yield return true;
            }
        }

        protected override IEnumerator GetCoroutineFunction()
        {
            return CheckAnimationPlaying();
        }
    }
}