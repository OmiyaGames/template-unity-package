using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace OmiyaGames.Template.Editor.Tests
{
    ///-----------------------------------------------------------------------
    /// <remarks>
    /// <copyright file="TestEditorExample.cs" company="Omiya Games">
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
    /// <strong>Version:</strong> 1.2.0<br/>
    /// <strong>Date:</strong> 4/5/2020<br/>
    /// <strong>Author:</strong> Taro Omiya
    /// </term>
    /// <description>Updated with proper example.</description>
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
    /// This is an example script for testing a package's editor script.
    /// </summary>
    /// <seealso cref="RuntimeExample"/>
    /// <seealso cref="Editor.EditorExample"/>
    public class TestEditorExample
    {
        /// <summary>
        /// A Test behaves as an ordinary method
        /// </summary>
        [Test]
        public void TestEditorExampleSimplePasses()
        {
            // Use the Assert class to test conditions
        }

        /// <summary>
        /// A UnityTest behaves like a coroutine in Play Mode.
        /// In Edit Mode you can use the following line to skip a frame:
        /// <code>yield return null;</code>
        /// </summary>
        [UnityTest]
        public IEnumerator TestEditorExampleWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
