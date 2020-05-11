using UnityEngine;
using System.Collections.Generic;

namespace OmiyaGames.Template
{
    ///-----------------------------------------------------------------------
    /// <remarks>
    /// <copyright file="RuntimeExample.cs" company="Omiya Games">
    /// The MIT License (MIT)
    /// 
    /// Copyright (c) 2019-2020 Omiya Games
    /// 
    /// Permission is hereby granted, free of charge, to any person obtaining a copy
    /// of this software and associated documentation files (the "Software"), to deal
    /// in the Software without restriction, including without limitation the rights
    /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    /// copies of the Software, and to permit persons to whom the Software is
    /// furnished to do so, subject to the following conditions:
    /// 
    /// The above copyright notice and this permission notice shall be included in
    /// all copies or substantial portions of the Software.
    /// 
    /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    /// THE SOFTWARE.
    /// </copyright>
    /// <list type="table">
    /// <listheader>
    /// <term>Revision</term>
    /// <description>Description</description>
    /// </listheader>
    /// <item>
    /// <term>
    /// <strong>Version:</strong> 1.0.0<br/>
    /// <strong>Date:</strong> 12/31/2019<br/>
    /// <strong>Author:</strong> Taro Omiya
    /// </term>
    /// <description>Initial verison.</description>
    /// </item>
    /// <item>
    /// <term>
    /// <strong>Version:</strong> 1.3.0<br/>
    /// <strong>Date:</strong> 5/7/2019<br/>
    /// <strong>Author:</strong> Taro Omiya
    /// </term>
    /// <description>Updated documentation to support DocFX.</description>
    /// </item>
    /// </list>
    /// </remarks>
    ///-----------------------------------------------------------------------
    /// <summary>
    /// This is an example script for starting a package.
    /// </summary>
    /// <seealso cref="Editor.EditorExample"/>
    public class RuntimeExample : MonoBehaviour
    {
        /// <summary>
        /// An example of a member variable, visible on the inspector.
        /// </summary>
        [SerializeField]
        [Tooltip("This is an example of a tooltip")]
        int exampleField = 0;

        /// <summary>
        /// Start is called on the frame when a script is enabled just before
        /// any of the Update methods is called the first time.
        /// </summary>
        void Start()
        {
        }

        /// <summary>
        /// Update is called every frame, if the MonoBehaviour is enabled.
        /// </summary>
        void Update()
        {
        }
    }
}
